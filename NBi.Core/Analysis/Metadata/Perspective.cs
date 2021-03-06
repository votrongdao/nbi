﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NBi.Core.Analysis.Metadata
{
    public class Perspective : IField
    {
        public string Name { get; private set; }
        public MeasureGroupCollection MeasureGroups { get; private set; }
        public DimensionCollection Dimensions { get; private set; }

        public Perspective(string name)
        {
            Name = name;
            MeasureGroups = new MeasureGroupCollection();
            Dimensions = new DimensionCollection();
        }

        public Perspective Clone()
        {
            var p = new Perspective(Name);
            p.MeasureGroups = MeasureGroups.Clone();
            p.Dimensions = Dimensions.Clone();
            return p;
        }

        public ICollection<IField> GetChildStructure()
        {
            return Dimensions.GetChildStructure();
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public string Caption
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
    }
}
