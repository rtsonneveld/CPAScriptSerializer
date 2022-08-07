using System;
using System.Collections.Generic;
using System.IO;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.SND.Commands;

namespace CPAScriptSerializer.SND.Sections {

   public class SndMapE : CPAScriptSection {
      public SndMapE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(LoadEvent), typeof(LoadEvent)},
         {nameof(LoadResource), typeof(LoadResource)},
         {nameof(LoadBank), typeof(LoadBank)},
      };


      public override void WriteContent(StreamWriter writer)
      {
         throw new System.NotImplementedException();
      }
   }
}
