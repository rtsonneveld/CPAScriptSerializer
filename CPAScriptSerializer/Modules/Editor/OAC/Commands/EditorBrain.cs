using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands {
   public class EditorBrain : Command
   {
      [CommandParameter(0)] public string BrainPath;
   }
}
