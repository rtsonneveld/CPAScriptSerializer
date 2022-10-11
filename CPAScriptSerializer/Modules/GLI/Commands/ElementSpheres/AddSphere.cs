using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands.ElementSpheres {
   public class AddSphere : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public int CenterPointIndex;
      [CommandParameter(2)] public float Radius;
      [CommandParameter(3)] public CPAScriptReference<GameMaterial> Material;

   }
}
