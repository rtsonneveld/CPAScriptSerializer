using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.ISI {
   public class CPAScript_RLI : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(ISI.Sections.ISI), typeof(ISI.Sections.ISI)},
         {nameof(ISI.Sections.IS2), typeof(ISI.Sections.IS2)},
      };
   }
}
