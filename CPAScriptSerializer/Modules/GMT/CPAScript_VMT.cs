using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.GMT {
   public class CPAScript_VMT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Sections.Material), typeof(Sections.Material) },
         { nameof(Sections.FontSprite), typeof(Sections.FontSprite) },
         { nameof(GLI.Sections.Texture), typeof(GLI.Sections.Texture) },
      };
   }
}
