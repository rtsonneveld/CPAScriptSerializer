using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer {
   
   /// <summary>
   /// Generic section that can be used if the section and its contents are not important and can be ignored
   /// </summary>
   public class DummySection : CPAScriptSection {

      public DummySection(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new() { };
      public override Type CommandTypeFallback(string name) => typeof(DummyCommand);
   }
}
