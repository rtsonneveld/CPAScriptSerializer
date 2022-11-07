using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndThemePartListE;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND {

   /// <summary>
   /// CPA Sound Bank? (unconfirmed)
   /// </summary>
   public class CPAScript_CSB : CPAScript {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(CsbHeader), typeof(CsbHeader) },
         { nameof(SoundBankList), typeof(SoundBankList) },
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

         { nameof(SndThemePartListE), typeof(SndThemePartListE) },
         { nameof(SndThemePartE), typeof(SndThemePartE) },

         { nameof(SndThemePartListM), typeof(SndThemePartListM) },
         { nameof(SndThemePartM), typeof(SndThemePartM) },

         { nameof(SndTrackListE), typeof(SndTrackListE) },
         { nameof(SndTrackE), typeof(SndTrackE) },

         { nameof(SndTrackListM), typeof(SndTrackListM) },
         { nameof(SndTrackM), typeof(SndTrackM) },

         { nameof(SndThemePartOutroM), typeof(SndThemePartOutroM) },
         { nameof(SndThemePartOutroE), typeof(SndThemePartOutroE) },

         { nameof(SndSwitchListM), typeof(SndSwitchListM) },
         { nameof(SndSwitchListE), typeof(SndSwitchListE) },

         { nameof(SndSwitchElementM), typeof(SndSwitchElementM) },
         { nameof(SndSwitchElementE), typeof(SndSwitchElementE) },

         { nameof(ResPlugInData), typeof(ResPlugInData) },
      };
   }
}
