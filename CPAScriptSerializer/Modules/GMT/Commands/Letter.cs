using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GMT.Commands {

   // Unused in R2 but here's a stub anyway

   [UnusedByCPA]
   public class Letter : Command
   {
      [CommandParameter(0)] public string Character;
      // Not bothering with the rest of the parameters
   }
}
