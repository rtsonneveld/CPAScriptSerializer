using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Dynam {

   [UnusedByCPA]
   public class SlideFactorBase : Command
   {
      [CommandParameter(0)] public float Value;
   }
}
