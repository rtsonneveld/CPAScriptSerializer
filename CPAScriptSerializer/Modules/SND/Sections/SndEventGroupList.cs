using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections {

   public class SndEventGroupList : CPAScriptSection {
      public SndEventGroupList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(LoadEventGroup), typeof(LoadEventGroup)},
      };

      public override Type CommandTypeFallback => null;
   }
}
