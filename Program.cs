using System;
using System.Xml.Serialization;
using System.IO;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using System.Linq;
using System.Text;
using System.IO;

namespace process_xml_into_dynamo
{
    class Program
    {

        static AmazonDynamoDBConfig clientConfig;
        static AmazonDynamoDBClient client;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            clientConfig = new AmazonDynamoDBConfig();
            // Set the endpoint URL
            clientConfig.ServiceURL = "http://localhost:8000";            
            client = new AmazonDynamoDBClient(clientConfig); 

            // get an item from a table 
            // Table table = Table.LoadTable(client, "Entitlement");
            // Document document = table.GetItemAsync("CE#4009002680").Result;

            // foreach (var item in document.Values)
            // {
            //   Console.WriteLine(item);   
            // }            

            // read xml from file below

            foreach (var item in Directory.GetFiles("C:/temp/xml_de-ce"))
            {                                            
                //System.IO.FileStream file = System.IO.File.Create(path);  
                Console.WriteLine($"loading file : {item}");
                var ent = ReadXMLFile(item);
                AddToDynamoDB(ent);
            }
            

        }

        public static Entitlement ReadXMLFile(string path)
        {                        
            XmlSerializer serializer = new XmlSerializer(typeof(Entitlement));
            StreamReader reader = new StreamReader(path);
            Entitlement ent = (Entitlement)serializer.Deserialize(reader);            
            reader.Close();
            return ent;
        }
    
        public static void AddToDynamoDB(Entitlement ent)
        {
            Table table = Table.LoadTable(client, "Entitlement");
            var entitlement = new Document();

            // Set the attributes that you wish to update.
            entitlement["Tenant_Customer"] = $"DECE{ent.CustomerIdentifier}";

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Entitlement));  
            
            MemoryStream stream = new MemoryStream();

            writer.Serialize(stream,ent);

            var contents = Encoding.UTF8.GetString(stream.GetBuffer(), 0 , (int)stream.Length);

            // Replace the authors attribute.
            entitlement["Entitlement"] = contents;
 
            // Add a new attribute.
            entitlement["SoftwareSerialNumber"] = "xxxx";
            // Delete the existing PageCount attribute.
            entitlement["BackOfficeTimeStamp"] = ent.BackOfficeTimestamp;

            var res = table.UpdateItemAsync(entitlement).Result;
            
            return;
        }
    
    }    
}
