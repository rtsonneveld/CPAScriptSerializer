using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class GameMaterial : VariableBase
   {
      // TODO: reference
      [CommandParameter(2)] public string Value;
   }
}
