using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class LinearSpeed : Command
   {
      [CommandParameter(0)] public float LinearSpeedValue;
      [CommandParameter(1)] public float LinearIncreaseSpeed;
      [CommandParameter(2)] public float LinearDecreaseSpeed;
   }
}
