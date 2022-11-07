using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.MEC.Sections;

namespace CPAScriptSerializer.Modules.MEC {
   public class CPAScript_MEC : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(IdCardBase), typeof(IdCardBase) },
         { nameof(IdCardCamera), typeof(IdCardCamera) },
      };
   }
}
