using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.AddCommands;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class A3dQuaternionsTable : CPAScriptSection {
      public A3dQuaternionsTable(string sectionId, string sectionType = null) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {"Add", typeof(QuaternionsTableAdd)},
      };
   }
}
