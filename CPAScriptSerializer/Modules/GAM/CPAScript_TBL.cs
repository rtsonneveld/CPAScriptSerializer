using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_TBL : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Sections.TBL.TBL), typeof(Sections.TBL.TBL)},
         {nameof(Sections.TBL.TBL_HEADER), typeof(Sections.TBL.TBL_HEADER)},
         {nameof(Sections.TBL.EVT), typeof(Sections.TBL.EVT)},
         // {nameof(Commands.TBL.LipsSynchro), typeof(Commands.TBL.LipsSynchro)}, TODO: support LipsSynchro stuff

      };
   }
}
