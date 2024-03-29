﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndRandomElementE : CPAScriptSection {
      public SndRandomElementE(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource.LoadResourceE) },
      };
      
   }
}
