using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight {
   public class GiroPhare : Command
   {
      [CommandParameter(0)] public byte OnOff;
      [CommandParameter(1)] public float Step;
   }
}
