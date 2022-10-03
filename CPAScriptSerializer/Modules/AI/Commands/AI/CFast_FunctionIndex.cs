using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.AI {
   
   public class CFast_FunctionIndex : Command
   {
      [CommandParameter(0)] public int FunctionIndex;
   }
}
