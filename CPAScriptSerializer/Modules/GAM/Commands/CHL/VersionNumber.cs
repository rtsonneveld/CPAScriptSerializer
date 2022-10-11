using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CHL {

   [UnusedByCPA]
   public class VersionNumber : Command
   {
      [CommandParameter(0)] public int Version;
   }
}
