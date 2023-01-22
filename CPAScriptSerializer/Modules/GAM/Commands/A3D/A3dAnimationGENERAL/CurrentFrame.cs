using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dAnimationGENERAL {

   [UnusedByCPA]
   public class CurrentFrame : Command
   {
      [CommandParameter(0)] public int Value;
   }
}
