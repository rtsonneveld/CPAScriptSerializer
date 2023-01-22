using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.Speed;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class Speed : CPAScriptSection {
      public Speed(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         {nameof(TranslationSpeed), typeof(TranslationSpeed)},
         {nameof(RotationSpeed), typeof(RotationSpeed)},
      };
   }
}
