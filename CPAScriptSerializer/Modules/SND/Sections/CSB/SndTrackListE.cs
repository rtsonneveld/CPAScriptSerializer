using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndTrackListE : CPAScriptSection {
      public SndTrackListE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(SndTrackE), typeof(SndTrackE)},
      };
   }
}
