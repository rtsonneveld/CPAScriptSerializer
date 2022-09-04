using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB {
   public class SetParam2 : Command {
      [CommandParameter(0)] public string Param;
   }
}
