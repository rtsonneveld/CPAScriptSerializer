using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OSC.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Sections {
   public class Sector : CPAScriptSection {
      public Sector(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(StaticLights), typeof(StaticLights) },
         { nameof(SectorsLink), typeof(SectorsLink) },
         { nameof(ENVAndSRF), typeof(ENVAndSRF) },
         { nameof(Border), typeof(Border) },
         { nameof(Sections.Gothrough), typeof(Sections.Gothrough) },
      };
   }
}
