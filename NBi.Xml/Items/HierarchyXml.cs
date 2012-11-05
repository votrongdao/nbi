﻿using System;
using System.Linq;
using System.Xml.Serialization;
using NBi.Core.Analysis.Discovery;

namespace NBi.Xml.Items
{
    public class HierarchyXml : DimensionXml
    {
        [XmlAttribute("dimension")]
        public string Dimension { get; set; }

        public override object Instantiate()
        {
            //TODO here?
            return null;
        }

        [XmlIgnore]
        protected string ParentPath { get { return string.Format("[{0}]", Dimension); } }
        [XmlIgnore]
        public string Path { get { return string.Format("{0}.[{1}]", ParentPath, Caption); } }
    }
}
