using CPAScriptSerializer.Modules.SND.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands.CSB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB
{
    public class SndSwitchElementM : CPAScriptSection
    {
        public SndSwitchElementM(string sectionId, string sectionType) : base(sectionId, sectionType) { }

        public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
        {
           { nameof(LoadResource), typeof(LoadResource.LoadResourceM) },
           { nameof(SetInfoValue), typeof(SetInfoValue) },
           { nameof(SoundInfoValue), typeof(SoundInfoValue) },
        };
    }
}
