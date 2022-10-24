using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands {
   public class ShowPrivate : Command
   {
      // TODO: 0/1 boolean
      [CommandParameter(0)] public int ShowPrivateToggle;
   }
}
