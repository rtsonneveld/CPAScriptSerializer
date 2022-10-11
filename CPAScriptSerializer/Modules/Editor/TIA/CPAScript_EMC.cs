using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TIA.Sections;

namespace CPAScriptSerializer.Modules.Editor.TIA {
   public class CPAScript_EMC : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateEditorMacro), typeof(CreateEditorMacro)},
         {nameof(CreateEditorBehaviour), typeof(CreateEditorBehaviour)},
      };
   }
}
