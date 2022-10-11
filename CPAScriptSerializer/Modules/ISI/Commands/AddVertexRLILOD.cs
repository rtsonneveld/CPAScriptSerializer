using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.ISI.Commands {
   public class AddVertexRLILOD : Command
   {
      [CommandParameter(0)] public short Index;
      [CommandParameter(1)] public short Red;
      [CommandParameter(2)] public short Green;
      [CommandParameter(3)] public short Blue;
      [CommandParameter(4)] public short Alpha;

   }
}
