using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.AI.Commands.AI;

namespace CPAScriptSerializer.Modules.AI.Sections.AI {
   public class CreateAIDefines : CPAScriptSection {
      public CreateAIDefines(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ConstantRef), typeof(ConstantRef) },
         { nameof(RealRef), typeof(RealRef) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
