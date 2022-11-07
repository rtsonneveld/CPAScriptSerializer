using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   [UnusedByCPA]
   public class AddLstStaticLights : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Light> Light;
   }
}
