using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight {
   public class IntensityMinMax : Command
   {
      [CommandParameter(0)] public float IntensityMin;
      [CommandParameter(1)] public float IntensityMax;
   }
}
