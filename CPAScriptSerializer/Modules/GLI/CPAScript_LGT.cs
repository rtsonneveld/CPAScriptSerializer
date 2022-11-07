using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.GLI {
   public class CPAScript_LGT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Matrix), typeof(Matrix) },
         { nameof(Light), typeof(Light) },
      };
   }
}
