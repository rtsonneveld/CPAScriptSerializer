﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TIA.Commands;

namespace CPAScriptSerializer.Modules.Editor.TIA.Sections {
   public class CreateEditorIntelligence : CPAScriptSection {
      public CreateEditorIntelligence(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateEditorBehaviour), typeof(CreateEditorBehaviour)},
      };
   }
}