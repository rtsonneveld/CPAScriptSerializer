using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.Matrix {
   public class MatrixScale : Command
   {
      [CommandParameter(0)] public float Matrix0;
      [CommandParameter(1)] public float Matrix1;
      [CommandParameter(2)] public float Matrix2;
      [CommandParameter(3)] public float Matrix3;
      [CommandParameter(4)] public float Matrix4;
      [CommandParameter(5)] public float Matrix5;
      [CommandParameter(6)] public float Matrix6;
      [CommandParameter(7)] public float Matrix7;
      [CommandParameter(8)] public float Matrix8;
   }
}
