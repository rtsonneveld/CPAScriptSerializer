﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndTrackListM : CPAScriptSection {
      public SndTrackListM(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(SndTrackM), typeof(SndTrackM)},
      };
   }
}
