using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OSC.Commands;
using CPAScriptSerializer.Modules.Editor.OSC.Sections;

namespace CPAScriptSerializer.Modules.Editor.OSC {
   public class CPAScript_SCT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Sector), typeof(Sector) },
         { nameof(StaticLights), typeof(StaticLights) },
         { nameof(SectorsLink), typeof(SectorsLink) },
         { nameof(ENVAndSRF), typeof(ENVAndSRF) },
         { nameof(Border), typeof(Border) },
         { nameof(Sections.Gothrough), typeof(Sections.Gothrough) },
      };
   }
}
