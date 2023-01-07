using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB
{
   [UnusedByCPA]
   public class SndResourceE : CPAScriptSection
   {
      public SndResourceE(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetName), typeof(SetName) },
         { nameof(SetComment), typeof(SetComment) },
         { nameof(SndRandomListE), typeof(SndRandomListE) },
         { nameof(SndThemePartListE), typeof(SndThemePartListE) },
         { nameof(SndTrackListE), typeof(SndTrackListE) },
         { nameof(ResPlugInData), typeof(ResPlugInData)},
         { nameof(SndThemePartOutroE), typeof(SndThemePartOutroE)},
      };

      
   }
}