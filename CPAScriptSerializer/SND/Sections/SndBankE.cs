using System;
using System.Collections.Generic;
using System.IO;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.SND.Commands;

namespace CPAScriptSerializer.SND.Sections {

   /*
    * This section isn't implemented anywhere in CPA it seems? Only referenced in SoundEditor.exe
    */
   public class SndBankE : CPAScriptSection {
      public SndBankE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(LoadEvent), typeof(LoadEvent)},
         {nameof(LoadResource), typeof(LoadResource)},
      };

      public override void WriteContent(StreamWriter writer)
      {
         throw new System.NotImplementedException();
      }
   }
}
