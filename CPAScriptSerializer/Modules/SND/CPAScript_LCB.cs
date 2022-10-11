using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.SND.Sections.LCB;

namespace CPAScriptSerializer.Modules.SND
{
   /// <summary>
   /// Level (CPA) Sound Bank
   /// </summary>
   public class CPAScript_LCB : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(LcbHeader), typeof(LcbHeader) },
         { nameof(SndEventGroupList), typeof(SndEventGroupList) },
         { nameof(SndBankE), typeof(SndBankE) },
         { nameof(SndMapE), typeof(SndMapE) },
         { nameof(SndEventIdList), typeof(SndEventIdList) },
         { nameof(SndResIdList), typeof(SndResIdList) },
      };
   }
}