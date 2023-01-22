using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.AddCommands {
   public class VertexesTableAdd : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public float X;
      [CommandParameter(2)] public float Y;
      [CommandParameter(3)] public float Z;
   }
}
