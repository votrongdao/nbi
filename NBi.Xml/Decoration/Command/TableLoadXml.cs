﻿using System;
using System.Linq;
using System.Xml.Serialization;
using NBi.Core.DataManipulation;

namespace NBi.Xml.Decoration.Command
{
    public class TableLoadXml : DataManipulationAbstractXml, ILoadCommand
    {
        [XmlAttribute("name")]
        public string TableName { get; set; }
        
        [XmlAttribute("file")]
        public string FileName { get; set; }
    }
}
