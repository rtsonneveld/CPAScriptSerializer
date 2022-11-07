using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Light {
   public class SetAlphas : Command
   {
      [CommandParameter(0)] public float LittleAlpha;
      [CommandParameter(1)] public float BigAlpha;
   }
}
