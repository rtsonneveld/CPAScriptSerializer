using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class TargetSpeed : Command
   {
      [CommandParameter(0)] public float TargetSpeedValue;
      [CommandParameter(1)] public float TargetIncreaseSpeed;
      [CommandParameter(2)] public float TargetDecreaseSpeed;
   }
}
