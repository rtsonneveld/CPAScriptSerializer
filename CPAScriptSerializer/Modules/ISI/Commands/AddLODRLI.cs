using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.ISI.Commands {
   public class AddLODRLI : Command
   {
      [CommandParameter(0)] public int IndexOfISILOD;
      [CommandParameter(1)] public int NumberOfRLI;
   }
}
