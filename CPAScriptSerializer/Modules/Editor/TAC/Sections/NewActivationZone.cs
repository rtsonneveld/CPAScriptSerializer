using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.Editor.TAC.Commands;

namespace CPAScriptSerializer.Modules.Editor.TAC.Sections {
   public class NewActivationZone : CPAScriptSection {
      public NewActivationZone(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ZdxIndex), typeof(ZdxIndex) },
      };
      
   }
}
