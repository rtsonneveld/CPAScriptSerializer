using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OZO.Commands;

namespace CPAScriptSerializer.Modules.Editor.OZO.Sections {
   public class CS : CPAScriptSection {
      public CS(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ZDR), typeof(ZDR) },
         { nameof(ZDD), typeof(ZDD) },
         { nameof(ZDE), typeof(ZDE) },
      };
   }
}

