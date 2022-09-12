using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.GLI {

   public class CPAScript_TEX : CPAScript {

      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Sections.Texture), typeof(Sections.Texture) },
      };
   }
}
