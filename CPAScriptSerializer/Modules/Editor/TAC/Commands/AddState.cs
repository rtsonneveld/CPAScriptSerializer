using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.TAC.Commands {
   public class AddState : Command
   {
      [CommandParameter(0)] public string State;
   }
}
