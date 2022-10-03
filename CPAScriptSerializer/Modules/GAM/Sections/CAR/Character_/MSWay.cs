using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class MSWay : CPAScriptSection {

      public MSWay(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; }
      public override Type CommandTypeFallback(string name) => null;
   }
}
