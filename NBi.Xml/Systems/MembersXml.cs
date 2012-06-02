﻿using System;
using System.Xml.Serialization;
using NBi.Core.Analysis.Member;

namespace NBi.Xml.Systems
{
    public class MembersXml : AbstractSystemUnderTestXml
    {
        [XmlAttribute("perspective")]
        public string Perspective { get; set; }

        [XmlAttribute("path")]
        public string Path { get; set; }

        [XmlAttribute("connectionString")]
        public string ConnectionString { get; set; }

        public override object Instantiate()
        {
            var cmd = new AdomdMemberCommand(ConnectionString);

            cmd.Perspective = Perspective;
            cmd.Path = Path;

            return cmd;
        }
    }
}
