using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OSC.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Sections {
   public class StaticLights : CPAScriptSection {
      public StaticLights(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddLstStaticLights), typeof(AddLstStaticLights) },
      };
   }
}
