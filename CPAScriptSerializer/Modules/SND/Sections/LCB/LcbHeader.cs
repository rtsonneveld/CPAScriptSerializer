using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.LCB;

namespace CPAScriptSerializer.Modules.SND.Sections.LCB
{
   public class LcbHeader : CPAScriptSection
   {
      public LcbHeader(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetDefaultLanguage), typeof(SetDefaultLanguage) },
         { nameof(VersionNumber), typeof(VersionNumber) },
         { nameof(SetNextFreeGroupId), typeof(SetNextFreeGroupId) },
      };

      
   }
}