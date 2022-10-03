using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.AI {
   public class RealRef : Command
   {
      [CommandParameter(0)]
      public float Value;
   }
}
