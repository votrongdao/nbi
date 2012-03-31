﻿using System;


namespace NBi.QueryGenerator
{
    [Serializable]
    public class Measure
    {
        public string UniqueName { get; private set; }
        public string Caption { get; set; }

        public Measure(string uniqueName, string caption)
        {
            UniqueName = uniqueName;
            Caption = caption;
        }

        public Measure Clone()
        {
            return new Measure(UniqueName, Caption);
        }
    }
}
