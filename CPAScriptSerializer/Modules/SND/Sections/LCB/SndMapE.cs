﻿using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.LCB;

namespace CPAScriptSerializer.Modules.SND.Sections.LCB
{
   public class SndMapE : CPAScriptSection
   {
      public SndMapE(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadEvent), typeof(LoadEvent) },
         { nameof(LoadResource), typeof(LoadResource.LoadResourceE) },
         { nameof(LoadBank), typeof(LoadBank) },
      };

      
   }
}