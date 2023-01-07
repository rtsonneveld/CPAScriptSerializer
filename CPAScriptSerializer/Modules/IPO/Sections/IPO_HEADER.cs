using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPO.Commands;

namespace CPAScriptSerializer.Modules.IPO.Sections {
   public class IPO_HEADER : CPAScriptSection {
      public IPO_HEADER(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(VersionNumber), typeof(VersionNumber) },
      };
   }
}
