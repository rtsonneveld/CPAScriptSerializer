using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.MEC.Commands {
   public class MaxSpeed : Command
   {
      [CommandParameter(0)] public float MaxSpeedX;
      [CommandParameter(1)] public float MaxSpeedY;
      [CommandParameter(2)] public float MaxSpeedZ;
   }
}
