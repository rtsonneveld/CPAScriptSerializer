using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands.Generic;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class ResPlugInData : CPAScriptSection {

      private const string TestString = "TestString";

      public ResPlugInData(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { TestString, typeof(EmptyCommand) },
      };
   }
}
