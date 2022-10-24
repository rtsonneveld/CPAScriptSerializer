using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSLight {
   public class FarNear : Command
   {
      [CommandParameter(0)] public float Far;
      [CommandParameter(1)] public float Near;
   }
}
