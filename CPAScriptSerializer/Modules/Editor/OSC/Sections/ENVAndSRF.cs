using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OSC.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Sections {
   [UnusedByCPA]
   public class ENVAndSRF : CPAScriptSection {
      public ENVAndSRF(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddLstEnvironment), typeof(AddLstEnvironment) },
      };
   }
}
