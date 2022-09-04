using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.Matrix {
   public class MatrixTranslation : Command
   {
      [CommandParameter(0)] public float TranslateX;
      [CommandParameter(1)] public float TranslateY;
      [CommandParameter(2)] public float TranslateZ;
   }
}
