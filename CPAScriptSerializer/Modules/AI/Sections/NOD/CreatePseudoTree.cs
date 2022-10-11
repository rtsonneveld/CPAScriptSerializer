using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.AI.Commands.NOD;

namespace CPAScriptSerializer.Modules.AI.Sections.NOD {

   public class CreatePseudoTree : CPAScriptSection {
      public CreatePseudoTree(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(MakeNode), typeof(MakeNode) },
      };
   }
}
