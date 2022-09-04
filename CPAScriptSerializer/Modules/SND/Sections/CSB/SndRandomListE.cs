using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndRandomListE : CPAScriptSection {
      public SndRandomListE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SndRandomElementE), typeof(SndRandomElementE) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
