using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.LCB;

namespace CPAScriptSerializer.Modules.SND.Sections.LCB
{
   public class SndEventIdList : CPAScriptSection
   {
      public SndEventIdList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetEvent), typeof(SetEvent) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}