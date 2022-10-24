using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight {
   public class LittleBigAlpha : Command
   {
      [CommandParameter(0)] public float Little;
      [CommandParameter(1)] public float Big;
   }
}
