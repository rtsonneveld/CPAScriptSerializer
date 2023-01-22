using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.DeformationFrame;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {

   [UnusedByCPA] // Can't find this being parsed anywhere - possibly newer animation format?
   public class DeformationFrame : CPAScriptSection {
      public DeformationFrame(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      { }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         {nameof(DeformationLink), typeof(DeformationLink)},
      };
   }
}
