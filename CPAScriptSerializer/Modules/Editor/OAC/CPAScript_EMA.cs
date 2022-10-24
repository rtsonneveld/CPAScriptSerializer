using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OAC.Sections;

namespace CPAScriptSerializer.Modules.Editor.OAC {
   public class CPAScript_EMA : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateEditorActorModel), typeof(CreateEditorActorModel) },
         { nameof(MiniStructure), typeof(MiniStructure) },
      };
   }
}
