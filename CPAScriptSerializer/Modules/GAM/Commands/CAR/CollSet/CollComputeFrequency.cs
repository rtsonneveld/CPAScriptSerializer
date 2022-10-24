using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.CollSet {
   public class CollComputeFrequency : Command
   {
      [CommandParameter(0)] public int Frequency;

   }
}
