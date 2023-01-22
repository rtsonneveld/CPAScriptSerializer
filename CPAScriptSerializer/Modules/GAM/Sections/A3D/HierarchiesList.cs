using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class HierarchiesList : CPAScriptSection {
      public HierarchiesList(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         { nameof(A3dHIERARCHY), typeof(A3dHIERARCHY) },
      };
   }
}
