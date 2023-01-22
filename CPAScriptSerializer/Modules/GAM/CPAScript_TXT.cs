using CPAScriptSerializer.Modules.Editor.TIA.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Sections.TXT;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_TXT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Languages), typeof(Languages)},
         {nameof(AddNewStrings), typeof(AddNewStrings)},
      };
   }
}
