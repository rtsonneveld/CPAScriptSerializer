using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class List : VariableBase
   {
      [CommandParameter(2)] public int Size;
   }
}
