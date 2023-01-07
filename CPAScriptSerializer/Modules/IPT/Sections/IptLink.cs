using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPT.Commands;

namespace CPAScriptSerializer.Modules.IPT.Sections {
   public class IptLink : CPAScriptSection {
      public IptLink(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddRef), typeof(AddRef) },
      };

      
   }
}
