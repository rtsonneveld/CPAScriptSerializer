using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndThemePartListE;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndThemePartOutroE : CPAScriptSection {
      public SndThemePartOutroE(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource.LoadResourceE) },
      };
   }
}
