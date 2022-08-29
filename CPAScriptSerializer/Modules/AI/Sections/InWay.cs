using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI.Sections {

   // TODO: find an example of this section filled with data - haven't found it yet in either .way or .wp - RTS
   public class InWay : CPAScriptSection {

      public InWay(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>() { };
      public override Type CommandTypeFallback => null;
   }
}
