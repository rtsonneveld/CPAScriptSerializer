using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class Repeat : Command
   {
      [CommandParameter(0)] public byte Value;
   }
}
