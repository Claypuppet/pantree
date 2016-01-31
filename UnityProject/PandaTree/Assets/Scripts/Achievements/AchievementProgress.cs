using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

public class AchievementProgress {

    public AchievementProgress() {
        Achieved = new _Achieved();
        Achieved.Value = false;
    }

    [XmlElement("Id")]
    public string Id { get; set; }

    [XmlRoot("Achieved")]
    public class _Achieved {
        [XmlAttribute("didPopup")]
        public bool didPopup { get; set; }
        [XmlText]
        public bool Value { get; set; }
    }

    [XmlElement("Achieved")]
    public _Achieved Achieved { get; set; }

    [XmlArray("Values")]
    [XmlArrayItem("Value")]
    public List<AchievementDefinition.Value> Values { get; set; }
}

[XmlRoot("AchievementProgressions")]
public class AchievementProgressions {
    [XmlElement(ElementName = "AchievementProgress")]
    public List<AchievementProgress> Progressions { get; set; }
}
