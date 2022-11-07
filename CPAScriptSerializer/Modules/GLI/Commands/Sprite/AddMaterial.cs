using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands.Sprite {
   public class AddMaterial : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public CPAScriptReference<GameMaterial> Material;
   }
}
