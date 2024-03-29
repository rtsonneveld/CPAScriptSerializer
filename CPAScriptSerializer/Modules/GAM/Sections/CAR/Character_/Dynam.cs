﻿using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.Dynam;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class Dynam : CPAScriptSection
   {

      [CommandParameter(0)] public EnumDynamSize DynamSize;
      [CommandParameter(1)] public int EnableCollision;

      public Dynam(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(DynamicsType), typeof(DynamicsType) },
         { nameof(TakeCareOfTheEnvironment), typeof(TakeCareOfTheEnvironment) },
         { nameof(SlideFactorX), typeof(SlideFactorX) },
         { nameof(SlideFactorY), typeof(SlideFactorY) },
         { nameof(SlideFactorZ), typeof(SlideFactorZ) },
      };

   }
}
