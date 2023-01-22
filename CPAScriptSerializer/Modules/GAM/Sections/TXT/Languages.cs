using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.TXT;

namespace CPAScriptSerializer.Modules.GAM.Sections.TXT {
   public class Languages : CPAScriptSection {
      public Languages(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddLanguage), typeof(AddLanguage)},
      };
   }
}
