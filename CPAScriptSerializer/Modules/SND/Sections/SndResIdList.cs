using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections
{
   public class SndResIdList : CPAScriptSection
   {
      public SndResIdList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetResource), typeof(SetResource) },
      };

      public override Type CommandTypeFallback => null;
   }
}