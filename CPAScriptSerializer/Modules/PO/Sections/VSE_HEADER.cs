using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.PO.Commands;

namespace CPAScriptSerializer.Modules.PO.Sections {
   public class VSE_HEADER : CPAScriptSection {
      public VSE_HEADER(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(VersionNumber), typeof(VersionNumber) },
      };
   }
}
