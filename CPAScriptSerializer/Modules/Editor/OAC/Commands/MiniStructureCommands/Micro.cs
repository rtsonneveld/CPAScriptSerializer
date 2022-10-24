using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {
   public class Micro {
      public class Is_Active : MiniStructureCommandBase { [CommandParameter(1)] public bool IsActive; }
   }
}
