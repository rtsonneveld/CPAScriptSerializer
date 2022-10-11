using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.EVT {
   public class FirstCall : Command
   {
      [CommandParameter(0)] public int Value; // Number of animation loops before event
   }
}
