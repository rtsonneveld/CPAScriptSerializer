using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.AI.Sections.NOD;

namespace CPAScriptSerializer.Modules.AI {

   /// <summary>
   /// CFast related
   /// </summary>
   public class CPAScript_NOD : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreatePseudoTree), typeof(CreatePseudoTree) },
      };
   }
}
