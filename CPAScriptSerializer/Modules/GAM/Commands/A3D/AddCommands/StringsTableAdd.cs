using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.AddCommands {
   public class StringsTableAdd : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public string String;
   }
}
