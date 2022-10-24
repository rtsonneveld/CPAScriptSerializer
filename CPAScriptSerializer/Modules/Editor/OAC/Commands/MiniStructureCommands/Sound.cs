using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class Sound {
      public class Satur_Distance : MiniStructureCommandBase { [CommandParameter(1)] public int SaturDistance; }
      public class Satur_Distance_Init : MiniStructureCommandBase { [CommandParameter(1)] public int SaturDistanceInit; }
      public class BackGround_Distance : MiniStructureCommandBase { [CommandParameter(1)] public int BackgroundDistance; }
      public class BackGround_Distance_Init : MiniStructureCommandBase { [CommandParameter(1)] public int BackgroundDistanceInit; }
   }
}
