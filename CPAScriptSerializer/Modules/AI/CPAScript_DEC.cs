using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.DEC;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI
{
   public class CPAScript_DEC : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(CreateVariables), typeof(CreateVariables) },
      };
   }
}