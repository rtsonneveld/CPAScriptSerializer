using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class Theta : Command
   {
      [CommandParameter(0)] public float AngleTheta;
      [CommandParameter(1)] public float AngleShiftTheta;
   }
}
