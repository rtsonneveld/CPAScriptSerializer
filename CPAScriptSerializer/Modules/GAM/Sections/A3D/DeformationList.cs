using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {

   [UnusedByCPA] // Can't find this being parsed anywhere - possibly newer animation format?
   public class DeformationList : CPAScriptSection {
      public DeformationList(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         { nameof(DeformationFrame), typeof(DeformationFrame) },
      };
   }
}
