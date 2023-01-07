using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TAC.Sections;
using CPAScriptSerializer.Modules.GAM.Sections.STA;

namespace CPAScriptSerializer.Modules.Editor.TAC.Commands {
   public class ActivationZone : Command
   {
      [CommandParameter(0)] public CPAScriptReference<NewActivationZone> Zone;
      [CommandParameter(1)] public CPAScriptReference<CreateNewState> State;
   }
}
