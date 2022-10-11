using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TAC.Commands;

namespace CPAScriptSerializer.Modules.Editor.TAC.Sections {
   public class CreateNewEDTAction : CPAScriptSection {
      public CreateNewEDTAction(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddDefaultState), typeof(AddDefaultState) },
         { nameof(AddTransitionalState), typeof(AddTransitionalState) },
         { nameof(AddState), typeof(AddState) },
         { nameof(Initial), typeof(Initial) },
      };

      
   }
}
