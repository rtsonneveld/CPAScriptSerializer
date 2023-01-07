using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_.CreateComport_;

namespace CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_ {
   public class CreateComport : CPAScriptSection {

      [CommandParameter(0)] public int ComportIndex; // Todo: add validation
      [CommandParameter(1)] public int NumberOfRules; // Todo: add validation

      public CreateComport(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateRule), typeof(CreateRule) },
         { nameof(CreateSchedule), typeof(CreateSchedule) },
      };

      
   }
}
