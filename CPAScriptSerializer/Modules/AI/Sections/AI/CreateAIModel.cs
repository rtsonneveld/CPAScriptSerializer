using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.AI.Commands.AI;

namespace CPAScriptSerializer.Modules.AI.Sections.AI {
   public class CreateAIModel : CPAScriptSection {
      public CreateAIModel(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateVariableDeclarationAIModel), typeof(CreateVariableDeclarationAIModel)},
         {nameof(CreateIntellAIModel), typeof(CreateIntellAIModel)},
         {nameof(CreateReflexAIModel), typeof(CreateReflexAIModel)},
         {nameof(CreateMacroAIModel), typeof(CreateMacroAIModel)},
         {nameof(CFast_IsC), typeof(CFast_IsC)},
         {nameof(CFast_FunctionIndex), typeof(CFast_FunctionIndex)},
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
