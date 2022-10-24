using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class Distance : Command
   {
      [CommandParameter(0)] public float DistMin;
      [CommandParameter(1)] public float DistMax;
      [CommandParameter(2)] public float BoundDistMin;
      [CommandParameter(3)] public float BoundDistMax;
   }
}
