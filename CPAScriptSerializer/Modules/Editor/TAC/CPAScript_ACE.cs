using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TAC.Sections;

namespace CPAScriptSerializer.Modules.Editor.TAC {
   public class CPAScript_ACE : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateNewEDTAction), typeof(CreateNewEDTAction) },
      };
   }
}
