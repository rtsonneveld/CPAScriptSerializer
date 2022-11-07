using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class MemoryDescription : CPAScriptSection
   {

      public const string NewBinaryMemoryDescription = "NewBinaryMemoryDescription";
      public const string BinaryMemoryDescriptionPass1 = "NewBinaryMemoryDescriptionPass1";
      public const string BinaryMemoryDescriptionPass2 = "NewBinaryMemoryDescriptionPass2";

      public MemoryDescription(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {MemoryCommand.ACPFixMemory, typeof(MemoryCommand)},
         {MemoryCommand.ACPMemory, typeof(MemoryCommand)},
         {MemoryCommand.ACPTextMemory, typeof(MemoryCommand)},
         {MemoryCommand.AIFixMemory, typeof(MemoryCommand)},
         {MemoryCommand.AIMemory, typeof(MemoryCommand)},
         {MemoryCommand.AnimationMemory, typeof(MemoryCommand)},
         {MemoryCommand.EngineObjectMemory, typeof(MemoryCommand)},
         {MemoryCommand.FontMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.GameFixMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.GameLevelMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.GameTempLevelMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.IPTMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.LipsSynchMemory, typeof(MemoryCommand)},
         {MemoryCommand.MenuMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.PositionMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.SAIFixMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.SAIMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.ScriptMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.SuperObjectMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.TMPFixMemory, typeof(MemoryCommand)},
         {MemoryCommand.TMPLevelMemory, typeof(MemoryCommand)},
         {MemoryCommand._3DMemorySize, typeof(MemoryCommand)},
         {MemoryCommand.Gap, typeof(MemoryCommand)},

         {nameof(UseMemorySnapshot), typeof(UseMemorySnapshot)},
      };
   }
}
