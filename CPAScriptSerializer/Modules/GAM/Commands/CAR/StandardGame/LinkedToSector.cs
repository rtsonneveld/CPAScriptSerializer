using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   [UnusedByCPA]
   public class LinkedToSector : Command
   {
      [CommandParameter(0)] public int Linked;
   }
}
