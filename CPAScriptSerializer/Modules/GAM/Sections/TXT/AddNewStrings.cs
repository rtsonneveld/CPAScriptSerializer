using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.TXT;

namespace CPAScriptSerializer.Modules.GAM.Sections.TXT {
   public class AddNewStrings : CPAScriptSection {

      // TODO: Add validation
      [CommandParameter(0)] public int NumStrings;

      public AddNewStrings(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(NewString), typeof(NewString)},
         {"Newstring", typeof(NewString)},
         {nameof(NewStringLength), typeof(NewStringLength)},
         {"NewStringLenght", typeof(NewStringLength)},
      };
   }
}
