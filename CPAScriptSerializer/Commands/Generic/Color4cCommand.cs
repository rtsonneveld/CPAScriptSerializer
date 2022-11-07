using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands.Generic {
   public class Color4cCommand : Command {
      [CommandParameter(0)] public byte Red;
      [CommandParameter(1)] public byte Green;
      [CommandParameter(2)] public byte Blue;
      [CommandParameter(3)] public byte Alpha;
   }
}
