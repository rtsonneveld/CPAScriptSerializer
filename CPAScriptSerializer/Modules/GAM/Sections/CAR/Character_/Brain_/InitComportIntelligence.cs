﻿using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_.Brain_ {
   public class InitComportIntelligence :CPAScriptSection {
      public InitComportIntelligence(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }


      [CommandParameter(0)]
      public CPAScriptReference<CreateComport> InitialComportIntelligence;

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };

      
   }
}
