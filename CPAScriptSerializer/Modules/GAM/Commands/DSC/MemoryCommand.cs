using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class MemoryCommand : Command
   {
      public const string ACPFixMemory = "ACPFixMemory";
      public const string ACPMemory = "ACPMemory";
      public const string ACPTextMemory = "ACPTextMemory";
      public const string AIFixMemory = "AIFixMemory";
      public const string AIMemory = "AIMemory";
      public const string AnimationMemory = "AnimationMemory";
      public const string EngineObjectMemory = "EngineObjectMemory";
      public const string FontMemorySize = "FontMemorySize";
      public const string GameFixMemorySize = "GameFixMemorySize";
      public const string GameLevelMemorySize = "GameLevelMemorySize";
      public const string GameTempLevelMemorySize = "GameTempLevelMemorySize";
      public const string IPTMemorySize = "IPTMemorySize";
      public const string LipsSynchMemory = "LipsSynchMemory";
      public const string MenuMemorySize = "MenuMemorySize";
      public const string PositionMemorySize = "PositionMemorySize";
      public const string SAIFixMemorySize = "SAIFixMemorySize";
      public const string SAIMemorySize = "SAIMemorySize";
      public const string ScriptMemorySize = "ScriptMemorySize";
      public const string SuperObjectMemorySize = "SuperObjectMemorySize";
      public const string TMPFixMemory = "TMPFixMemory";
      public const string TMPLevelMemory = "TMPLevelMemory";
      public const string _3DMemorySize = "3DMemorySize";
      public const string Gap = "Gap";

      [CommandParameter(0)] public int Size;
   }
}
