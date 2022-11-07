using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample;
using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndThemePartListE
{
   public class SndThemePartM : CPAScriptSection
   {
      private const string SetStartLoop = "SetStartLoop";
      private const string SetEndLoop = "SetEndLoop";

      public SndThemePartM(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetTransitionType), typeof(SetTransitionType) },
         { nameof(LoadResource), typeof(LoadResource.LoadResourceM) },
         { SetStartLoop, typeof(SetOptionBool) },
         { nameof(SetNumberOfLoops), typeof(SetNumberOfLoops) },
         { SetEndLoop, typeof(SetOptionBool) },
      };
   }
}
