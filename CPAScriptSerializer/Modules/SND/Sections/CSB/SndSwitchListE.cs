using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndSwitchListE : CPAScriptSection {
      public SndSwitchListE(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SndSwitchElementE), typeof(SndSwitchElementE) },
      };
   }
}
