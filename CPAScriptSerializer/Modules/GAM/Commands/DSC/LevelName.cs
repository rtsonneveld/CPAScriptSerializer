using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class LevelName : Command
   {
      [CommandParameter(0)] public string Level;
   }
}
