using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.ISI.Sections;

namespace CPAScriptSerializer.Modules.PO.Commands {
   /// <summary>
   /// "RLI file" (Received Light Intensity)
   /// </summary>
   public class FichierRLI : Command
   {
      [CommandParameter(0)] public CPAScriptReference<RLI> RLIReference;
   }
}
