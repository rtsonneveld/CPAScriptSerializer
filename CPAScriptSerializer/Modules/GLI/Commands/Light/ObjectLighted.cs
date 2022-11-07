using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Light {
   public class ObjectLighted : Command
   {
      [CommandParameter(0)] public EnumObjectLighted ObjectLightedMask;
   }
}
