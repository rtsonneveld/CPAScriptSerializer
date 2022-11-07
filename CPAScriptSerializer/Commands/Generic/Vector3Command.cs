using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands.Generic {
   public class Vector3Command : Command {
      [CommandParameter(0)] public float X;
      [CommandParameter(1)] public float Y;
      [CommandParameter(2)] public float Z;
   }
}
