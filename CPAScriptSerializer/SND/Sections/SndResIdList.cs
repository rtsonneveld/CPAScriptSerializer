using System;
using System.Collections.Generic;
using System.IO;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.SND.Commands;

namespace CPAScriptSerializer.SND.Sections {

   public class SndResIdList : CPAScriptSection {
      public SndResIdList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(SetResource), typeof(SetResource)},
      };

      public override void WriteContent(StreamWriter writer)
      {
         throw new System.NotImplementedException();
      }
   }
}
