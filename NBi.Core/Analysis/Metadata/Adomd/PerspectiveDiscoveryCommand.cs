﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NBi.Core.Analysis.Discovery;

namespace NBi.Core.Analysis.Metadata.Adomd
{
    internal class PerspectiveDiscoveryCommand : AdomdDiscoveryCommand
    {
        public PerspectiveDiscoveryCommand(string connectionString) : base(connectionString)
        {

        }

        public virtual PerspectiveCollection List(IEnumerable<IFilter> filters)
        {
            var perspectives = new PerspectiveCollection();
            
            Inform("Investigating perspectives");

            using (var cmd = CreateCommand())
            {
                var adomdFiltering = Build(filters);
                cmd.CommandText = string.Format("select * from $system.mdschema_dimensions where 1=1{0}", adomdFiltering);
                var rdr = ExecuteReader(cmd);
                // Traverse the response and 
                // read column 2, "CUBE_NAME"
                while (rdr.Read())
                {
                    string perspectiveName = (string)rdr.GetValue(2);
                    if (!perspectiveName.StartsWith("$"))
                    {
                        //Manage Perspectives 
                        perspectives.AddOrIgnore(perspectiveName);
                    }
                }
            }

            return perspectives;
        }


        public override IEnumerable<IField> GetCaptions(IEnumerable<IFilter> filters)
        {
            var values = List(filters);
            return values.Values.ToArray();
        }

        public virtual string Build(IEnumerable<IFilter> filters)
        {
            var filterString = string.Empty;
            foreach (var filter in filters)
            {
                if (filter != null)
                    filterString += string.Format(" and {0}", Build((CaptionFilter)filter));
            }

            return filterString;
        }

        protected override string Build(CaptionFilter filter)
        {
            if (filter.Target==DiscoveryTarget.Perspectives)
                    return string.Format("CUBE_NAME='{0}'", filter.Value);

            return string.Empty;
        }
    }
}
