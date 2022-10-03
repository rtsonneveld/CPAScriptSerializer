using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   public class TransparencyZone : Command
   {
      [CommandParameter(0)] public byte ZoneMin;
      [CommandParameter(1)] public byte ZoneMax;
   }
}
