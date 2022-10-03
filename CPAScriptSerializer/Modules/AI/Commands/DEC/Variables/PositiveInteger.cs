using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class PositiveInteger : VariableBase
   {
      [CommandParameter(2)] public uint Value;
   }
}
