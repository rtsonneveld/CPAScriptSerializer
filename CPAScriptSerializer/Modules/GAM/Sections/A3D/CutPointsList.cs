using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.CutPointsList;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class CutPointsList : CPAScriptSection {
      public CutPointsList(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         {nameof(CutPoint), typeof(CutPoint)},
      };
   }
}
