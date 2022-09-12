using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GMT {
   public class CPAScript_GMT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Sections.GameMaterial), typeof(Sections.GameMaterial) },
      };
   }
}
