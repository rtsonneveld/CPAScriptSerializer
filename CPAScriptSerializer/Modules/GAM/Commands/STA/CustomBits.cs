using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class CustomBits : Command
   {
      [CommandParameter(0)] public int Value;
   }
}
