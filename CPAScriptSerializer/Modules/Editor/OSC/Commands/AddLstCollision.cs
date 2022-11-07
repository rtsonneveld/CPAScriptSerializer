using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   public class AddLstCollision : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SuperObject> SuperObject;
   }
}
