using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OZO.Sections;

namespace CPAScriptSerializer.Modules.Editor.OZO {

   /// <summary>
   /// Module Zdx (zones)
   /// </summary>
   public class CPAScript_ZOO : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ZOO_HEADER), typeof(ZOO_HEADER) },
         { nameof(AllCollideSets), typeof(AllCollideSets) },
         { nameof(CS), typeof(CS) },
      };
   }
}
