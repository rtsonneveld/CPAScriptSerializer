using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndRandomElementM;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndRandomElementM : CPAScriptSection {
      public SndRandomElementM(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource) },
         { nameof(SetProbability), typeof(SetProbability) },
         { nameof(SetElementCanBeChoosenTwice), typeof(SetElementCanBeChoosenTwice) },
      };
      public override Type CommandTypeFallback(string name) => null;
   }
}
