using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.TXT;

namespace CPAScriptSerializer.Modules.GAM.Sections.TXT {
   public class Languages : CPAScriptSection
   {
      // TODO: Add validation
      [CommandParameter(0)] public int NumLanguages;

      public Languages(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddLanguage), typeof(AddLanguage)},
      };
   }
}
