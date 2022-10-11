using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SNA.Sections;

namespace CPAScriptSerializer.Modules.SNA {
   public class CPAScript_PGB : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Vignette), typeof(Vignette) },
      };
   }
}
