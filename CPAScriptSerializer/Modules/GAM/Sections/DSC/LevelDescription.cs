using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class LevelDescription : CPAScriptSection
   {
      public LevelDescription(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(NumberOfAlways), typeof(NumberOfAlways) },
         { nameof(BeginMapSoundEvent), typeof(BeginMapSoundEvent) }
      };
   };
}
