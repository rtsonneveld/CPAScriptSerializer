using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dAnimationGENERAL {

   [UnusedByCPA] // Can't find this being parsed anywhere - possibly newer animation format?
   public class NBOfFramesForInterAnimInterpol : Command
   {
      [CommandParameter(0)] public int NumberOfFrames;
   }
}
