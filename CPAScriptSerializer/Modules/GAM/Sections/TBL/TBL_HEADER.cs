using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.TBL;
using CPAScriptSerializer.Modules.GAM.Commands.TBL.TBL_HEADER;

namespace CPAScriptSerializer.Modules.GAM.Sections.TBL {
   public class TBL_HEADER : CPAScriptSection {
      public TBL_HEADER(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(VersionNumber), typeof(VersionNumber) },
         { nameof(MaximumIndex), typeof(MaximumIndex) },
      };
   }
}
