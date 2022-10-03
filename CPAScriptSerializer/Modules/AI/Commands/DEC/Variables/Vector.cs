using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class Vector : VariableBase
   {
      [CommandParameter(2)] public float ValueX;
      [CommandParameter(3)] public float ValueY;
      [CommandParameter(4)] public float ValueZ;
   }
}
