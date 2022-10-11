using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TGM.Sections;

namespace CPAScriptSerializer.Modules.Editor.TGM {
   public class CPAScript_CMT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CollideMaterial), typeof(CollideMaterial) }
      };
   }
}
