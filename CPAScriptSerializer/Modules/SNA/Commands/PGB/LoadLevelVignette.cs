using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SNA.Commands.PGB {
   public class LoadLevelVignette : Command
   {
      [CommandParameter(0)] public string VignetteFile;
   }
}
