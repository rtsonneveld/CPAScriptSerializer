using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TIA.Sections;

namespace CPAScriptSerializer.Modules.Editor.TIA {
   public class CPAScript_ESB : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateEditorSubr), typeof(CreateEditorSubr)},
         {nameof(CreateEditorBehaviour), typeof(CreateEditorBehaviour)},
      };
   }
}
