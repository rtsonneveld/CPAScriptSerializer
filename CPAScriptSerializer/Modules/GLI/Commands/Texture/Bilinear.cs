using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Enums;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class Bilinear : Command
   {
      [CommandParameter(0)] public EnumOnOffToggle FilterX;
      [CommandParameter(1)] public EnumOnOffToggle FilterY;
   }
}
