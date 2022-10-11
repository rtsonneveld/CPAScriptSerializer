using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.PO.Sections;

namespace CPAScriptSerializer.Modules.PO {
   public class CPAScript_VSE : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(VSE_HEADER), typeof(VSE_HEADER) },
         { nameof(VS), typeof(VS) },
          {nameof(LOD), typeof(LOD) },
      };
   }
}
