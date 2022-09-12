using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Enums;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class Tiling : Command
   {
      [CommandParameter(0)] public EnumOnOffToggle TilingX;
      [CommandParameter(1)] public EnumOnOffToggle TilingY;
   }
}
