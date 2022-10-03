using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.AI.Sections.MAC {
   public class CreateListOfMacro : CPAScriptSection {
      public CreateListOfMacro(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateMacro), typeof(CreateMacro) }
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
