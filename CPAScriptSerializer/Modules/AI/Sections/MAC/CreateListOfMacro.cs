using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Sections.MAC {
   public class CreateListOfMacro : CPAScriptSection
   {

      [CommandParameter(0)] public int NumberOfMacros; // Todo: add validation

      public CreateListOfMacro(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateMacro), typeof(CreateMacro) }
      };

      
   }
}
