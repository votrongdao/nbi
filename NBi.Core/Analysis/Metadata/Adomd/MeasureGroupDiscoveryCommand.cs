﻿using System;
using System.Collections.Generic;
using System.Linq;
using NBi.Core.Analysis.Request;

namespace NBi.Core.Analysis.Metadata.Adomd
{
    internal class MeasureGroupDiscoveryCommand : PerspectiveDiscoveryCommand
    {
        public MeasureGroupDiscoveryCommand(string connectionString)
            : base(connectionString)
        {

        }

        public new virtual MeasureGroupCollection List(IEnumerable<IFilter> filters)
        {
            var measureGroups = new MeasureGroupCollection();

            var rows = Discover(filters);
            foreach (var row in rows)
            {
                measureGroups.AddOrIgnore(row.Name);
            }

            return measureGroups;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        internal new IEnumerable<MeasureGroupRow> Discover(IEnumerable<IFilter> filters)
        {
            var measureGroups = new List<MeasureGroupRow>();
            
            Inform("Investigating measure-groups");

            using (var cmd = CreateCommand())
            {
                var adomdFiltering = Build(filters);
                cmd.CommandText = string.Format("SELECT * FROM $system.mdschema_measures WHERE MEASURE_IS_VISIBLE{0}", adomdFiltering);
                var rdr = ExecuteReader(cmd);

                while (rdr.Read())
                {
                    var row = MeasureGroupRow.Load(rdr);
                    if (row != null)
                        if (!measureGroups.Exists(mg => mg.Name==row.Name && mg.PerspectiveName==row.PerspectiveName))
                            measureGroups.Add(row);
                }
            }

            return measureGroups;
        }

        public override IEnumerable<IField> Execute()
        {
            var values = List(Filters);
            return values.Values.ToArray();
        }

        protected override string Build(CaptionFilter filter)
        {
            var str = base.Build(filter);
            if (!String.IsNullOrEmpty(str))
                return str;

            if (filter.Target == DiscoveryTarget.MeasureGroups)
                return string.Format("[MEASUREGROUP_NAME]='{0}'", filter.Value);

            return string.Empty;
        }
    }
}
