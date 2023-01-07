using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class MSLight : CPAScriptSection
   {

      [CommandParameter(0)]
      public EnumLightType LightType;

      public MSLight(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(On), typeof(On)},
         {nameof(FarNear), typeof(FarNear)},
         {nameof(LittleBigAlpha), typeof(LittleBigAlpha)},
         {nameof(LittleBigTangent), typeof(LittleBigTangent)},
         {nameof(Color), typeof(Color)},
         {nameof(GiroPhare), typeof(GiroPhare)},
         {nameof(Pulse), typeof(Pulse)},
         {nameof(Offset), typeof(Offset)},
         {nameof(Direction), typeof(Direction)},
         {nameof(LocalLight), typeof(LocalLight)},
         {nameof(OnlyLocalLight), typeof(OnlyLocalLight)},
         {nameof(InterMinPos), typeof(InterMinPos)},
         {nameof(InterMaxPos), typeof(InterMaxPos)},
         {nameof(ExterMinPos), typeof(ExterMinPos)},
         {nameof(ExterMaxPos), typeof(ExterMaxPos)},
         {nameof(IntensityMinMax), typeof(IntensityMinMax)},
      };
   }
}
