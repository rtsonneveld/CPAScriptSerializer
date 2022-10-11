using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.CAR.MSSound;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class MSSound : CPAScriptSection {
      public MSSound(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(SaturationDistance), typeof(SaturationDistance)},
         {nameof(BackGroundDistance), typeof(BackGroundDistance)},
      };
   }
}
