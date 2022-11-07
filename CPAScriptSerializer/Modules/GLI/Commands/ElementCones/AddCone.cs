using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands.ElementCones {
   public class AddCone : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public int TopPoint;
      [CommandParameter(2)] public int BasePoint;
      [CommandParameter(3)] public float BaseRadius;
      [CommandParameter(4)] public CPAScriptReference<GameMaterial> Material;
   }
}
