using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.TBL;
using CPAScriptSerializer.Modules.GAM.Commands.TBL.TBL;

namespace CPAScriptSerializer.Modules.GAM.Sections.TBL {
   public class TBL : CPAScriptSection {
      public TBL(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(PHY), typeof(PHY) },
         { nameof(CustomZoom), typeof(CustomZoom) },
      };
   }
}
