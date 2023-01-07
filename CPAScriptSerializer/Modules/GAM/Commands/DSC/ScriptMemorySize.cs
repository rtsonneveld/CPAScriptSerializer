using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class ScriptMemorySize : Command
   {
      [CommandParameter(0)] public int Module;
      [CommandParameter(1)] public int Size;
   }
}
