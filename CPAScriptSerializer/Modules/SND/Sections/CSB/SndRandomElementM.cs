using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndRandomElementM;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndRandomElementM : CPAScriptSection {
      public SndRandomElementM(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource.LoadResourceM) },
         { nameof(SetProbability), typeof(SetProbability) },
         { nameof(SetElementCanBeChoosenTwice), typeof(SetElementCanBeChoosenTwice) },
      };
      
   }
}
