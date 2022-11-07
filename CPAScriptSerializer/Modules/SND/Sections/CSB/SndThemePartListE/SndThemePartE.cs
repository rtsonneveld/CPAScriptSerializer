﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndThemePartListE {
   public class SndThemePartE : CPAScriptSection {
      public SndThemePartE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource.LoadResourceE) },
      };
   }
}
