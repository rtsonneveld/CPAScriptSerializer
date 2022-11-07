using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   public class GoThrough : Command {
      [CommandParameter(0)]
      public CPAScriptReference<Geometric> GoThroughGeometric;
   }
}
