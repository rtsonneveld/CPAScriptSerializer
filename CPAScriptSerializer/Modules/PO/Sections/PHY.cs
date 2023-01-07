using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.PO.Sections {
   public class PHY : CPAScriptSection {
      public PHY(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Commands.VS), typeof(Commands.VS) },
         { nameof(Commands.CS), typeof(Commands.CS) },
         // BV seems unused, not implemented for now
      };
   }
}
