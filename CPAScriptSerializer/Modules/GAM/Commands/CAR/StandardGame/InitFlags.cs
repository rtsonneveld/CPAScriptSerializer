using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   public class InitFlags : Command
   {
      [CommandParameter(0)] public EnumInitFlags InitFlagWhenOutOfZone;
      [CommandParameter(1)] public EnumInitFlags InitFlagWhenDeadOrTaken;
   }
}
