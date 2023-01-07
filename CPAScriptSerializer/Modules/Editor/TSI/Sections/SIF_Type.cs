using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.TSI.Sections {
   public class SIF_Type : CPAScriptSection {
      public SIF_Type(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; }
   }
}
