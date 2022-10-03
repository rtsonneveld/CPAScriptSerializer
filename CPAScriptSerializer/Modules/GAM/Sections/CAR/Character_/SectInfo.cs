using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_ {
   public class SectInfo : CPAScriptSection {

      public SectInfo(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; }
      public override Type CommandTypeFallback(string name) => null;
   }
}
