using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   public class AddLstGraphic : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SuperObject> SuperObject;
      [CommandParameter(1)] public int LOD;
      [CommandParameter(2)] public int DisplayMode;
   }
}
