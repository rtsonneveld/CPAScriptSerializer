using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.AI {
   public class ConstantRef : Command
   {
      [CommandParameter(0)]
      public string Name;
      [CommandParameter(1)]
      public int Value;
   }
}
