using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands.CSB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SoundBankList : CPAScriptSection {
      public SoundBankList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetNextFreeResourceId), typeof(SetNextFreeResourceId) },
         { nameof(SetNextFreeEventId), typeof(SetNextFreeEventId) },
      };
   }
}
