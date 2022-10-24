using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class AngularSpeed : Command
   {
      [CommandParameter(0)] public float AngularSpeedValue;
      [CommandParameter(1)] public float AngularIncreaseSpeed;
      [CommandParameter(2)] public float AngularDecreaseSpeed;
   }
}
