using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Enums;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class ZWrite : Command
   {
      [CommandParameter(0)] public EnumOnOffToggle EnableZWrite;
   }
}
