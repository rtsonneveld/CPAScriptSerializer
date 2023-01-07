using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Commands.NOD;

namespace CPAScriptSerializer.Modules.AI.Sections.NOD {

   public class CreatePseudoTree : CPAScriptSection
   {
      [CommandParameter(0)] public int NumberOfNodes;

      public CreatePseudoTree(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(MakeNode), typeof(MakeNode) },
      };
   }
}
