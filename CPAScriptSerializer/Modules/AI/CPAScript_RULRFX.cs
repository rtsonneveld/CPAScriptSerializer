using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_.CreateComport_;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI
{
   // .rul and .rfx
   public class CPAScript_RULRFX : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         {nameof(CreateIntelligence), typeof(CreateIntelligence)},

         // Subsections
         {nameof(CreateComport), typeof(CreateComport)},
         {nameof(CreateRule), typeof(CreateRule) },
      };
   }
}