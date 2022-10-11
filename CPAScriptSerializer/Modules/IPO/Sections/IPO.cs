using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.IPO.Sections {
   public class IPO : CPAScriptSection {
      public IPO(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Commands.PO), typeof(Commands.PO)},
         {nameof(Commands.RLI), typeof(Commands.RLI)},
      };
   }
}
