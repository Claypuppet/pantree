using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("AchievmentDefinition")]
public class AchievementDefinition {
    [XmlElement("Id")]
    public string Id { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("Icon")]
    public string Icon { get; set; }

    [XmlElement("Secret")]
    public bool Secret { get; set; }

    [XmlRoot("Value")]
    public class Value {
        [XmlAttribute("Id")]
        public string Id { get; set; }
        [XmlText]
        public string ValueString { get; set; }

        public ValueType GetValue<ValueType>() {
            if(ValueString == null)
                return default(ValueType);
            return (ValueType)Convert.ChangeType(ValueString, typeof(ValueType));
        }

        public void SetValue<ValueType>(ValueType value) {
            ValueString = value.ToString();
        }
    }

    [XmlArray("Values")]
    [XmlArrayItem("Value")]
    public List<Value> Values { get; set; }
}

[XmlRoot("AchievementDefinitions")]
public class AchievementDefinitions {
    [XmlElement(ElementName = "AchievementDefinition")]
    public List<AchievementDefinition> Definitions { get; set; }
}
