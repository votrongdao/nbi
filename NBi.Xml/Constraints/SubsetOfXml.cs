﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;
using NBi.Core;
using NBi.Xml.Items;

namespace NBi.Xml.Constraints
{
    public class SubsetOfXml : AbstractConstraintXml
    {
        [XmlAttribute("ignore-case")]
        public bool IgnoreCase { get; set; }

        [XmlElement("item")]
        public List<string> Items { get; set; }

        [XmlElement("one-column-query")]
        public QueryXml Query { get; set; }


        public SubsetOfXml()
        {
            Items = new List<string>();
        }

    }
}
