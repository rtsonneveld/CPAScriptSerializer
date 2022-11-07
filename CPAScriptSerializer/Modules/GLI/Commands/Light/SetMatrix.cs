using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.GLI.Commands.Light {
   public class SetMatrix : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Matrix> Matrix;
   }
}
