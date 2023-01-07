using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections.LCB
{
   public class SndResIdList : CPAScriptSection
   {
      public SndResIdList(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetResource), typeof(SetResource) },
      };

      
   }
}