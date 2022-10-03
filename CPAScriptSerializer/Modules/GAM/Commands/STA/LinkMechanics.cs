using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.MEC.Sections;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class LinkMechanics : Command
   {
      [CommandParameter(0)] public CPAScriptReference<IdCardBase> LinkedMechanics;
   }
}
