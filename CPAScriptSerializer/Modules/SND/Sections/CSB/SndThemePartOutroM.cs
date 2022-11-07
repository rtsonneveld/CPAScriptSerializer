using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndThemePartListE;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndThemePartOutroM : CPAScriptSection {
      public SndThemePartOutroM(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource.LoadResourceM) },
         { nameof(SetTransitionType), typeof(SetTransitionType) },
      };
   }
}
