﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NBi.Xml.Items;

namespace NBi.Xml.Systems
{
    public class StructureXml: AbstractSystemUnderTestXml
    {
        [XmlElement(Type = typeof(PerspectiveXml), ElementName = "perspective"),
        XmlElement(Type = typeof(MeasureGroupXml), ElementName = "measure-group"),
        XmlElement(Type = typeof(MeasureXml), ElementName = "measure"),
        XmlElement(Type = typeof(DimensionXml), ElementName = "dimension"),
        XmlElement(Type = typeof(HierarchyXml), ElementName = "hierarchy"),
        XmlElement(Type = typeof(LevelXml), ElementName = "level"),
        XmlElement(Type = typeof(PerspectivesXml), ElementName = "perspectives"),
        XmlElement(Type = typeof(MeasureGroupsXml), ElementName = "measure-groups"),
        XmlElement(Type = typeof(MeasuresXml), ElementName = "measures"),
        XmlElement(Type = typeof(DimensionsXml), ElementName = "dimensions"),
        XmlElement(Type = typeof(HierarchiesXml), ElementName = "hierarchies"),
        XmlElement(Type = typeof(LevelsXml), ElementName = "levels")
        ]
        public AbstractItem Item { get; set; }

        public override BaseItem BaseItem
        {
            get
            {
                return Item;
            }
        }

        public virtual string GetConnectionString()
        {
            //if ConnectionString is specified then return it
            if (!string.IsNullOrEmpty(Item.ConnectionString))
                return Item.ConnectionString;

            //Else get the default ConnectionString 
            if (Default != null && !string.IsNullOrEmpty(Default.ConnectionString))
                return Default.ConnectionString;
            return null;
        }

        internal override Dictionary<string, string> GetRegexMatch()
        {
            return Item.GetRegexMatch();
        }

        public override ICollection<string> GetAutoCategories()
        {
            var values = Item.GetAutoCategories();
            values.Add("Structure");
            return values;
        }
    }
}
