
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://backoffice.sls.lspcs.sage.com", IsNullable = false)]
public partial class Entitlement
{

    private System.DateTime backOfficeTimestampField;

    private uint customerIdentifierField;

    private EntitlementSoftware[] softwareField;

    private EntitlementProperty[] propertyField;

    /// <remarks/>
    public System.DateTime BackOfficeTimestamp
    {
        get
        {
            return this.backOfficeTimestampField;
        }
        set
        {
            this.backOfficeTimestampField = value;
        }
    }

    /// <remarks/>
    public uint CustomerIdentifier
    {
        get
        {
            return this.customerIdentifierField;
        }
        set
        {
            this.customerIdentifierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Software")]
    public EntitlementSoftware[] Software
    {
        get
        {
            return this.softwareField;
        }
        set
        {
            this.softwareField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Property")]
    public EntitlementProperty[] Property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementSoftware
{

    private string softwareIDField;

    private string softwareSerialNumberField;

    private decimal softwareSerialVersionField;

    private System.DateTime validFromField;

    private System.DateTime validToField;

    private EntitlementSoftwareSoftwareConstraint[] softwareConstraintsField;

    private EntitlementSoftwareProperty[] propertyField;

    private EntitlementSoftwareModule[] moduleField;

    /// <remarks/>
    public string SoftwareID
    {
        get
        {
            return this.softwareIDField;
        }
        set
        {
            this.softwareIDField = value;
        }
    }

    /// <remarks/>
    public string SoftwareSerialNumber
    {
        get
        {
            return this.softwareSerialNumberField;
        }
        set
        {
            this.softwareSerialNumberField = value;
        }
    }

    /// <remarks/>
    public decimal SoftwareSerialVersion
    {
        get
        {
            return this.softwareSerialVersionField;
        }
        set
        {
            this.softwareSerialVersionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ValidFrom
    {
        get
        {
            return this.validFromField;
        }
        set
        {
            this.validFromField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ValidTo
    {
        get
        {
            return this.validToField;
        }
        set
        {
            this.validToField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("SoftwareConstraint", IsNullable = false)]
    public EntitlementSoftwareSoftwareConstraint[] SoftwareConstraints
    {
        get
        {
            return this.softwareConstraintsField;
        }
        set
        {
            this.softwareConstraintsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Property")]
    public EntitlementSoftwareProperty[] Property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Module")]
    public EntitlementSoftwareModule[] Module
    {
        get
        {
            return this.moduleField;
        }
        set
        {
            this.moduleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementSoftwareSoftwareConstraint
{

    private string nameField;

    private string valueField;

    private byte enforcementLevelField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public byte EnforcementLevel
    {
        get
        {
            return this.enforcementLevelField;
        }
        set
        {
            this.enforcementLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementSoftwareProperty
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementSoftwareModule
{

    private string nameField;

    private EntitlementSoftwareModuleProperty[] propertyField;

    private EntitlementSoftwareModuleConstraint[] constraintField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Property")]
    public EntitlementSoftwareModuleProperty[] Property
    {
        get
        {
            return this.propertyField;
        }
        set
        {
            this.propertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Constraint")]
    public EntitlementSoftwareModuleConstraint[] Constraint
    {
        get
        {
            return this.constraintField;
        }
        set
        {
            this.constraintField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementSoftwareModuleProperty
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementSoftwareModuleConstraint
{

    private string nameField;

    private string valueField;

    private byte enforcementLevelField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public byte EnforcementLevel
    {
        get
        {
            return this.enforcementLevelField;
        }
        set
        {
            this.enforcementLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://backoffice.sls.lspcs.sage.com")]
public partial class EntitlementProperty
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

