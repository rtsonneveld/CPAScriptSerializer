using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.LCB;

namespace CPAScriptSerializer.Modules.SND.Sections.LCB
{
   public class SndEventIdList : CPAScriptSection
   {
      public SndEventIdList(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetEvent), typeof(SetEvent) },
      };

      
   }
}