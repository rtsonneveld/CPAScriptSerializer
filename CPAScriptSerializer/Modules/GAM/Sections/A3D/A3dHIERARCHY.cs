using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dHIERARCHY;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class A3dHIERARCHY : CPAScriptSection {
      public A3dHIERARCHY(string sectionId, string sectionType = null) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new()
      {
         { nameof(ChannelAndFather), typeof(ChannelAndFather) },
      };
   }
}
