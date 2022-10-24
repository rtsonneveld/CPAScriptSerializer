using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class Capability : VariableBase
   {
      [CommandParameter(2, CustomDefaultValue = "CapaNull")] public uint Value;
   }
}
