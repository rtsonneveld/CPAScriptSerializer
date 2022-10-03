using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CHL {
   public class FileType : Command {
      [UnusedByCPA]
      [CommandParameter(0)] public string Type;
   }
}
