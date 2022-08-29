using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;

namespace CPAScriptSerializer.Modules.SND.Sections
{
   public class SndMapE : CPAScriptSection
   {
      public SndMapE(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadEvent), typeof(LoadEvent) },
         { nameof(LoadResource), typeof(LoadResource) },
         { nameof(LoadBank), typeof(LoadBank) },
      };

      public override Type CommandTypeFallback => null;
   }
}