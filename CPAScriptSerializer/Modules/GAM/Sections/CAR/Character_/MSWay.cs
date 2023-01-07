using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class MSWay : CPAScriptSection {

      public MSWay(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; }
      
   }
}
