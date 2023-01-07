using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Commands;
using CPAScriptSerializer.Modules.SND.Commands.CSB;
using CPAScriptSerializer.Modules.SND.Commands.LCB;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB
{
   public class CsbHeader : CPAScriptSection
   {
      public CsbHeader(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetNextFreeResourceId), typeof(SetNextFreeResourceId) },
         { nameof(SetNextFreeEventId), typeof(SetNextFreeEventId) },
         { nameof(VersionNumber), typeof(VersionNumber) },
         { nameof(ScriptVersion), typeof(ScriptVersion) },
         { nameof(SNDLibraryVersion), typeof(SNDLibraryVersion) },
         { nameof(SetEventGroupType), typeof(SetEventGroupType) },
      };

      
   }
}