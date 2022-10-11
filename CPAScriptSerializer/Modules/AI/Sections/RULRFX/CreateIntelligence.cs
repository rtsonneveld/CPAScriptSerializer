using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_;

namespace CPAScriptSerializer.Modules.AI.Sections.RULRFX {
   public class CreateIntelligence : CPAScriptSection {
      public CreateIntelligence(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateComport), typeof(CreateComport) }
      };

      
   }
}
