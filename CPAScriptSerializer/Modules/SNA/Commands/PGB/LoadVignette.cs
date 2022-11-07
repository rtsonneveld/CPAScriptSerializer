using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SNA.Commands.PGB {
   public class LoadVignette : Command
   {
      [CommandParameter(0)] public string VignetteFile;
   }
}
