using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.PO.Commands;

namespace CPAScriptSerializer.Modules.PO.Sections {
   public class LOD : CPAScriptSection {
      public LOD(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LOD_Threshold), typeof(LOD_Threshold) },
         { nameof(FichierMOD), typeof(FichierMOD) },
         { nameof(FichierRLI), typeof(FichierRLI) },
      };
   }
}
