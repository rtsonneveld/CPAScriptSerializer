using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.LCB;

namespace CPAScriptSerializer.Modules.SND.Sections.LCB
{
   /*
    * This section isn't implemented anywhere in CPA it seems? Only referenced in SoundEditor.exe
    */
   [UnusedByCPA]
   public class SndBankE : CPAScriptSection
   {
      public SndBankE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadEvent), typeof(LoadEvent) },
         { nameof(LoadResource), typeof(LoadResource) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}