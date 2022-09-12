using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class Quality : Command
   {
      [CommandParameter(0)] public EnumQuality TextureQuality;
   }
}
