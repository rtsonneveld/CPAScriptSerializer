using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.MAC;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI
{
   // .mac
   public class CPAScript_MAC : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         {nameof(CreateListOfMacro), typeof(CreateListOfMacro) },

         // Subsections
         {nameof(CreateMacro), typeof(CreateMacro) },
      };
   }
}