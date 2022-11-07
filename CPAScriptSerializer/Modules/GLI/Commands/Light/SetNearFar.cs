using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Light {
   public class SetNearFar : Command
   {
      [CommandParameter(0)] public float Near;
      [CommandParameter(1)] public float Far;
   }
}
