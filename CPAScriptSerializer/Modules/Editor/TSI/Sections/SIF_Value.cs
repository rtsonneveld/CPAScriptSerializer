using CPAScriptSerializer.Modules.Editor.TSI.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.TSI.Sections {
   public class SIF_Value : CPAScriptSection {
      public SIF_Value(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetValue), typeof(SetValue) },
      };
   }
}
