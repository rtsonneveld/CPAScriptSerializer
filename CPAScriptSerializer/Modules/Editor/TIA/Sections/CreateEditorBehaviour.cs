using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TIA.Commands;

namespace CPAScriptSerializer.Modules.Editor.TIA.Sections {
   public class CreateEditorBehaviour : CPAScriptSection {
      public CreateEditorBehaviour(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Name), typeof(Name)},
         {nameof(Language), typeof(Language)},
         {nameof(Text), typeof(Text)},
         {nameof(BoundingBox), typeof(BoundingBox)},
      };
   }
}
