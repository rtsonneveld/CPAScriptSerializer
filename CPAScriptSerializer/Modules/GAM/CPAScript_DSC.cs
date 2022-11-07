using CPAScriptSerializer.Modules.SNA.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Sections.DSC;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_DSC : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(DirectoriesDescription), typeof(DirectoriesDescription)},
         {nameof(LevelSoundBanks), typeof(LevelSoundBanks)},
         {nameof(LevelDescription), typeof(LevelDescription)},
         {nameof(MemoryDescription), typeof(MemoryDescription)},
         {MemoryDescription.NewBinaryMemoryDescription, typeof(MemoryDescription)},
         {MemoryDescription.BinaryMemoryDescriptionPass1, typeof(MemoryDescription)},
         {MemoryDescription.BinaryMemoryDescriptionPass2, typeof(MemoryDescription)},
         {nameof(InputDeviceManagerDescription), typeof(InputDeviceManagerDescription)},
         {nameof(RandomManagerDescription), typeof(RandomManagerDescription)},
         {nameof(GameOptionsFile), typeof(GameOptionsFile)},
         {nameof(BigFiles), typeof(BigFiles)},
         {nameof(Vignette), typeof(Vignette)},
         {nameof(AnimStacks), typeof(AnimStacks)},
         {nameof(Texts), typeof(Texts)},
         {nameof(FirstLevelDescription), typeof(FirstLevelDescription)},
         {nameof(BinaryUse), typeof(BinaryUse)},
      };
   }
}
