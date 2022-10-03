using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CHL {
   public class VersionNumber : Command
   {
      [UnusedByCPA]
      [CommandParameter(0)] public int Version;
   }
}
