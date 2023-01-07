using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer {
   
   /// <summary>
   /// Generic section that can be used whenever a section is always empty
   /// </summary>
   public class EmptySection : CPAScriptSection {

      public EmptySection(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new() { };
      public override Type CommandTypeFallback(string name)
      {
         throw new Exception("Empty sections cannot have any commands!");
      }
   }
}
