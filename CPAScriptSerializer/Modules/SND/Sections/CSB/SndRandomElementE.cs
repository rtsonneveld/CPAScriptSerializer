using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndRandomElementE : CPAScriptSection {
      public SndRandomElementE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadResource), typeof(LoadResource) },
      };
      public override Type CommandTypeFallback(string name) => null;
   }
}
