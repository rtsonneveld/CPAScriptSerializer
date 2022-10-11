using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.PO.Commands {
   /// <summary>
   /// "MOD file"
   /// </summary>
   public class FichierMOD : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Geometric> GeometricReference;
   }
}
