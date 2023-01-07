using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class LevelSoundBanks : CPAScriptSection {
      public LevelSoundBanks(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(LoadMap), typeof(LoadMap)},
         // SoundBanksBlock is implemented but doesn't seem used, maybe in old versions
      };
   }
}
