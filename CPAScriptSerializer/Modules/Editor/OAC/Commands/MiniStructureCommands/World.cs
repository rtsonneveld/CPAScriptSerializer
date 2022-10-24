using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class World {
      public class Snow_Force : MiniStructureCommandBase { [CommandParameter(1)] public int SnowForce; }
      public class Snow_Force_Init : MiniStructureCommandBase { [CommandParameter(1)] public int SnowForceInit; }
      public class Rain_Force : MiniStructureCommandBase {[CommandParameter(1)] public int RainForce; }
      public class Rain_Force_Init : MiniStructureCommandBase {[CommandParameter(1)] public int RainForceInit; }
      public class Wind_Vector : MiniStructureCommandVector {}
      public class Wind_Vector_Init : MiniStructureCommandVector {}
   }
}
