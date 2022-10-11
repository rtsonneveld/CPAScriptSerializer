using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.PO.Commands {
   public class LOD_Threshold : Command
   {
      [CommandParameter(0)] public int Threshold;
   }
}
