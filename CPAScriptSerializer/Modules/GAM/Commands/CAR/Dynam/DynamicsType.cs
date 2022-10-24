using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Dynam {
   [UnusedByCPA]
   public class DynamicsType : Command
   {
      [CommandParameter(0)] public string Type;
      [CommandParameter(1)] public string IsAMobile;
      [CommandParameter(2)] public string CanHangSmthgOn;
   }
}
