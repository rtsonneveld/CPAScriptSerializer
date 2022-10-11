using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.PO.Commands;

namespace CPAScriptSerializer.Modules.PO.Sections {
   public class PHY_HEADER : CPAScriptSection {
      public PHY_HEADER(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(VersionNumber), typeof(VersionNumber) },
      };
   }
}
