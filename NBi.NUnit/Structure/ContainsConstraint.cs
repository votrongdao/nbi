﻿using System;
using System.Collections;
using System.Collections.Generic;
using NBi.Core;
using NBi.Core.Analysis.Metadata;
using NBi.Core.Analysis.Request;
using NUnit.Framework.Constraints;
using NUnitCtr = NUnit.Framework.Constraints;

namespace NBi.NUnit.Structure
{
    public class ContainsConstraint : NUnitCtr.CollectionContainsConstraint
    {
        protected object _expected;
        protected string expectedCaption;
        protected string expectedDisplayFolder;
        protected IComparer comparer;
        protected MetadataDiscoveryRequest command;
        protected IMetadataExtractor _metadataExtractor;
        
        /// <summary>
        /// Engine dedicated to MetadataExtractor acquisition
        /// </summary>
        protected internal IMetadataExtractor MetadataExtractor
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                _metadataExtractor = value;
            }
        }

        protected IMetadataExtractor GetEngine(string connectionString)
        {
            if (_metadataExtractor == null)
                _metadataExtractor = new MetadataAdomdExtractor(connectionString);
            return _metadataExtractor;
        }

        /// <summary>
        /// Construct a CollectionContainsConstraint
        /// </summary>
        /// <param name="expected"></param>
        public ContainsConstraint(string expected)
            : base(StringComparerHelper.Build(expected))
        {
            _expected = expected;
            expectedCaption = expected;
            comparer = new NBi.Core.Analysis.Metadata.Field.ComparerByCaption(true);
        }

        /// <summary>
        /// Construct a CollectionContainsConstraint
        /// </summary>
        /// <param name="expected"></param>
        public ContainsConstraint(IFieldWithDisplayFolder expected)
            : base(expected)
        {
            _expected = expected;
            expectedCaption = expected.Caption;
            comparer = new NBi.Core.Analysis.Metadata.Field.ComparerByCaptionAndDisplayFolder(true);
        }

        #region Modifiers
        /// <summary>
        /// Flag the constraint to ignore case and return self.
        /// </summary>
        public new ContainsConstraint IgnoreCase
        {
            get
            {
                comparer = new NBi.Core.Analysis.Metadata.Field.ComparerByCaption(false);
                return this;
            }
        }

        #endregion

        public override bool Matches(object actual)
        {
            if (actual is MetadataDiscoveryRequest)
                return Process((MetadataDiscoveryRequest)actual);
            else
            {
                base.Using(comparer);
                var res= base.Matches(actual);
                return res; 
            }
        }

        public bool doMatch(IEnumerable<IField> actual)
        {
           return base.Using(comparer).Matches(actual);
        }

        
        protected bool Process(MetadataDiscoveryRequest actual)
        {
            command = actual;
            var extr = GetEngine(actual.ConnectionString);
            IEnumerable<IField> structures = extr.GetPartialMetadata(actual);
            return this.Matches(structures);
        }

        /// <summary>
        /// Write a description of the constraint to a MessageWriter
        /// </summary>
        /// <param name="writer"></param>
        public override void WriteDescriptionTo(MessageWriter writer)
        {
            if (command != null)
            {
                switch (command.Target)
                {
                    case DiscoveryTarget.MeasureGroups:
                        var displayFolder = (_expected is IFieldWithDisplayFolder) ? string.Format(", in folder \"{0}\", ", ((IFieldWithDisplayFolder)_expected).DisplayFolder) : " ";
                        writer.WritePredicate(string.Format("On perspective \"{0}\", the measuregroup \"{1}\" containing{2}a measure with caption"
                                                                               , command.GetFilter(DiscoveryTarget.Perspectives).Value
                                                                               , command.GetFilter(DiscoveryTarget.MeasureGroups).Value
                                                                               , displayFolder));
                        break;
                    case DiscoveryTarget.Dimensions:
                        writer.WritePredicate(string.Format("On perspective \"{0}\", a dimension labeled by \"{1}\" containing a hierarchy with caption"
                                                            , command.GetFilter(DiscoveryTarget.Perspectives).Value
                                                            , command.GetFilter(command.Target).Value));
                        break;
                    case DiscoveryTarget.Hierarchies:
                        writer.WritePredicate(string.Format("On perspective \"{0}\", a hierarchy labeled by \"{1}\", from dimension \"{2}\", containing a level with caption"
                                                            , command.GetFilter(DiscoveryTarget.Perspectives).Value
                                                            , command.GetFilter(DiscoveryTarget.Hierarchies).Value
                                                            , command.GetFilter(DiscoveryTarget.Dimensions).Value));
                        break;
                    default:
                        break;
                }
                
                writer.WriteExpectedValue(expectedCaption);
            }
            else
                base.WriteDescriptionTo(writer);
            
        }

    }
}
