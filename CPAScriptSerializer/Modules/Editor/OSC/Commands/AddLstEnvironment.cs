using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   [UnusedByCPA]
   public class AddLstEnvironment : Command
   {
      [CommandParameter(0)] public string Environment; // Unused but parse the string anyway
   }
}
