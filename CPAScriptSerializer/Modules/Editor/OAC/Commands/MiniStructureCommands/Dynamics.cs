using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class Dynamics {

      public class Size : MiniStructureCommandBase { [CommandParameter(1, customDefaultValue: "!! Unknown !!")] public EnumDynamSize DynamicsSize; };
      public class Collision : MiniStructureCommandBase { [CommandParameter(1)] public bool Enabled; };
      public class Slide_x : MiniStructureCommandBase { [CommandParameter(1)] public float SlideX; };
      public class Slide_y : MiniStructureCommandBase { [CommandParameter(1)] public float SlideY; };
      public class Slide_z : MiniStructureCommandBase { [CommandParameter(1)] public float SlideZ; };
   }
}
