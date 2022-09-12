using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.GMT.Enums;

namespace CPAScriptSerializer.Modules.GMT.Commands.Material {
   public class AddTexture : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public CPAScriptReference<Texture> TextureRef;
   }
}
