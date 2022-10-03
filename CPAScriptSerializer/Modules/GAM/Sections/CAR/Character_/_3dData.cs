﻿using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.CAR._3dData;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class _3dData : CPAScriptSection {

      public _3dData(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(InitialState), typeof(InitialState) },
         { nameof(DrawMask), typeof(DrawMask) },
         { nameof(ShadowScale), typeof(ShadowScale) },
         { nameof(ShadowQuality), typeof(ShadowQuality) },
         { nameof(ShadowHeight), typeof(ShadowHeight) },
         { nameof(LightComputationFrequency), typeof(LightComputationFrequency) },
      };

      public const string Name = "3dData";
      public override string SectionExportType => Name;

      public override Type CommandTypeFallback(string name) => null;
   }
}
