using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.Matrix {
   public class MatrixRotation : Command
   {
      [CommandParameter(0)] public float Col0X;
      [CommandParameter(1)] public float Col0Y;
      [CommandParameter(2)] public float Col0Z;

      [CommandParameter(3)] public float Col1X;
      [CommandParameter(4)] public float Col1Y;
      [CommandParameter(5)] public float Col1Z;

      [CommandParameter(6)] public float Col2X;
      [CommandParameter(7)] public float Col2Y;
      [CommandParameter(8)] public float Col2Z;
   }
}
