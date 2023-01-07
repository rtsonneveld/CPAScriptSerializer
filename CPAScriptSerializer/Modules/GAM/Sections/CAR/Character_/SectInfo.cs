using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class SectInfo : CPAScriptSection {

      public SectInfo(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; }
      
   }
}
