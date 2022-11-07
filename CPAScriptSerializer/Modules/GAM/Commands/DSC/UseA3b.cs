using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class UseA3b : Command
   {
      // TODO: 0/1 boolean
      [CommandParameter(0)] public int EnableUseA3b;
   }
}
