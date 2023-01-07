﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TIA.Commands;

namespace CPAScriptSerializer.Modules.Editor.TIA.Sections {
   public class CreateEditorReflex : CPAScriptSection {
      public CreateEditorReflex(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateEditorBehaviour), typeof(CreateEditorBehaviour)},
      };
   }
}
