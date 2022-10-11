using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_.Brain_;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class Brain : CPAScriptSection {

      public Brain(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(InitComportIntelligence), typeof(InitComportIntelligence) },
         { nameof(InitComportReflex), typeof(InitComportReflex) },
         { nameof(InitVariables), typeof(InitVariables) },
      };

      
   }
}
