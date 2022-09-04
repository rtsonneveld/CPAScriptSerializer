using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND {
   public class CPAScript_CSB : CPAScript {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(CsbHeader), typeof(CsbHeader) },
         { nameof(SndEventE), typeof(SndEventE) },
         { nameof(SndResourceE), typeof(SndResourceE) },
         { nameof(SndEventM), typeof(SndEventM) },
         { nameof(SndResourceM), typeof(SndResourceM) },

         /* subsections */
         { nameof(SndResourceDisk), typeof(SndResourceDisk) },

         { nameof(SndRandomListE), typeof(SndRandomListE) },
         { nameof(SndRandomElementE), typeof(SndRandomElementE) },

         { nameof(SndRandomListM), typeof(SndRandomListM) },
         { nameof(SndRandomElementM), typeof(SndRandomElementM) },
      };
   }
}
