using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB
{
   [UnusedByCPA]
   public class SndResourceM : CPAScriptSection
   {
      public SndResourceM(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SndResourceDisk), typeof(SndResourceDisk) },
         { nameof(SndRandomListM), typeof(SndRandomListM) },
         { nameof(SndThemePartListM), typeof(SndThemePartListM) },
         { nameof(SndThemePartOutroM), typeof(SndThemePartOutroM) },
      };

      
   }
}