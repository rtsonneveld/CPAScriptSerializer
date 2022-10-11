using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_.CreateComport_;

namespace CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_ {
   public class CreateComport : CPAScriptSection {
      public CreateComport(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateRule), typeof(CreateRule) },
         { nameof(CreateSchedule), typeof(CreateSchedule) },
      };

      
   }
}
