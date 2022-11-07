using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GLI.Commands.Light {
   public class SetState : Command
   {
      // TODO: 0/1 boolean
      [CommandParameter(0)] public int State;
   }
}
