using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TGM.Sections;

namespace CPAScriptSerializer.Modules.Editor.TGM {
   public class CPAScript_ED_MMT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(MechanicalMaterial), typeof(MechanicalMaterial) },
      };
   }
}
