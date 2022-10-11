using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.PO.Sections;

namespace CPAScriptSerializer.Modules.PO {
   public class CPAScript_PHY : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(PHY_HEADER), typeof(PHY_HEADER) },
         { nameof(PHY), typeof(PHY) },
      };
   }
}
