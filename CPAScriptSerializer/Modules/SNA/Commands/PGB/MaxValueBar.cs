using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SNA.Commands.PGB {
   public class MaxValueBar : Command
   {
      [CommandParameter(0)] public int MaxValue;
   }
}
