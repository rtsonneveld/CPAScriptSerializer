using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class ZMinMax : Command
   {
      [CommandParameter(0)] public float ZMin;
      [CommandParameter(1)] public float ZMax;
   }
}
