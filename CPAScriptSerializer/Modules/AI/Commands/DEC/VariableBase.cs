using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC {
   public abstract class VariableBase : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public string VariableName;
   }
}
