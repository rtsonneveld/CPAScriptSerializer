using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   public class CustomBitsInit : Command
   {
      [CommandParameter(0)] public uint Value;
   }
}
