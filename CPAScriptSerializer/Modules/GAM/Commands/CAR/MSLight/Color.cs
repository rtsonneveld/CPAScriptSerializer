using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight {
   public class Color : Command
   {
      [CommandParameter(0)] public float Red;
      [CommandParameter(1)] public float Green;
      [CommandParameter(2)] public float Blue;
      [CommandParameter(3)] public float Alpha;
   }
}
