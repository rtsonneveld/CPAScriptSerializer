using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class Alpha : Command
   {
      [CommandParameter(0)] public float AngleAlpha;
      [CommandParameter(1)] public float AngleShiftAlpha;
   }
}
