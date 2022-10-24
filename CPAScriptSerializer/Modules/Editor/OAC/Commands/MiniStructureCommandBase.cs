using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands {
   public class MiniStructureCommandBase : Command
   {
      [CommandParameter(0)] public EnumLinkedState LinkedState;
   }

   public class MiniStructureCommandVector : MiniStructureCommandBase {[CommandParameter(1)] public float X;[CommandParameter(2)] public float Y;[CommandParameter(3)] public float Z; }

}
