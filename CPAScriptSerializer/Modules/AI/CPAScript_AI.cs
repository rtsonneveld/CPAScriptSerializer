using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.AI;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI
{
   public class CPAScript_AI : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         {nameof(CreateAIModel), typeof(CreateAIModel)},
      };
   }
}