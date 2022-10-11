using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.NOD {
   public class MakeNode : Command
   {
      [CommandParameter(0)] public int TypeInterpret;
      [CommandParameter(1)] public int ValueInterpret;
      // Other parameters seem to go unused
   }
}
