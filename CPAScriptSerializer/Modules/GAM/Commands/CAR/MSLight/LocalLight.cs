using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight {
   public class LocalLight : Command
   {
      // TODO: 0/1 boolean
      [CommandParameter(0)] public int IsOn;
   }
}
