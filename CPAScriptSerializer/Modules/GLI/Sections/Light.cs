using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.STA;
using CPAScriptSerializer.Modules.GAM.Enums;
using CPAScriptSerializer.Modules.GLI.Commands.Light;
using CPAScriptSerializer.Modules.SPO.Commands.SuperObject;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   public class Light : CPAScriptSection
   {
      [CommandParameter(0)] public EnumLightType LightType;

      public Light(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(NoAlphaLight), typeof(NoAlphaLight)},
         { nameof(PaintLight), typeof(PaintLight)},
         { nameof(SetState), typeof(SetState)},
         { nameof(ObjectLighted), typeof(ObjectLighted)},
         { nameof(SetColor), typeof(SetColor)},
         { nameof(SetNearFar), typeof(SetNearFar)},
         { nameof(SetMatrix), typeof(SetMatrix)},
         { nameof(SetAlphas), typeof(SetAlphas)},
         { nameof(SetIntensityMinMax), typeof(SetIntensityMinMax)},
         { nameof(BackgroundColor), typeof(BackgroundColor)},
      };
   }
}
