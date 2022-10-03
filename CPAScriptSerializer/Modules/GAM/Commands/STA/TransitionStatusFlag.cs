using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class TransitionStatusFlag : Command
   {
      [CommandParameter(0)] public EnumTransitionStatusFlag Flag;
   }
}
