using System;
using System.Collections.Generic;
using System.IO;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.SND.Commands;

namespace CPAScriptSerializer.SND.Sections {

   public class SndEventGroupList : CPAScriptSection {
      public SndEventGroupList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(LoadEventGroup), typeof(LoadEventGroup)},
      };

      public override void WriteContent(StreamWriter writer)
      {
         throw new System.NotImplementedException();
      }
   }
}
