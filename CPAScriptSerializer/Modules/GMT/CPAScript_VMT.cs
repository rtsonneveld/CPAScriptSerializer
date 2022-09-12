using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GMT {
   public class CPAScript_VMT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Sections.Material), typeof(Sections.Material) },
      };
   }
}
