using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TSI.Sections;

namespace CPAScriptSerializer.Modules.Editor.TSI {
   public class CPAScript_SIF : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SIF_Type), typeof(SIF_Type) },
         { nameof(SIF_Value), typeof(SIF_Value) },
      };
   }
}
