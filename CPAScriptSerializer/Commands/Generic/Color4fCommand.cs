using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands.Generic {
   public class Color4fCommand : Command {
      [CommandParameter(0)] public float Red;
      [CommandParameter(1)] public float Green;
      [CommandParameter(2)] public float Blue;
      [CommandParameter(3)] public float Alpha;
   }
}
