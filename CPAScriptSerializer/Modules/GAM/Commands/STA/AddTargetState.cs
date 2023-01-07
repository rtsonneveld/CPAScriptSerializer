using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class AddTargetState : Command
   {
      [CommandParameter(0)] public string TargetState;
      [CommandParameter(1)] public string StateToGo;

      [CommandParameter(2)]
      public int LinkingType; // 0 for StandardLink, 1 for ProportionalLink, see State.h
   }
}
