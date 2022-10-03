using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   public class HitPointsMaxInit : Command
   {
      [CommandParameter(0)] public int Value;
   }
}
