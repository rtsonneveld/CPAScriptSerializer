using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.OZO.Sections {
   public class AllCollideSets : CPAScriptSection {
      public AllCollideSets(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CS), typeof(CS)},
      };
   }
}
