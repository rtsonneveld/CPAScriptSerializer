using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class SpeedsList : CPAScriptSection {
      public SpeedsList(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         {nameof(Speed), typeof(Speed)},
      };
   }
}
