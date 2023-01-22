﻿using CPAScriptSerializer.Modules.GAM.Commands.A3D.AddCommands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Sections.A3D {
   public class A3dVertexesTable : CPAScriptSection {
      public A3dVertexesTable(string sectionId, string sectionType = null) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {"Add", typeof(VertexesTableAdd)},
      };
   }
}
