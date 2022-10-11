using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SNA.Commands.PGB {
   public class InitBarOutlineColor : Command
   {
      [CommandParameter(0)] public byte Red;
      [CommandParameter(1)] public byte Green;
      [CommandParameter(2)] public byte Blue;
      [CommandParameter(3)] public byte Alpha;
   }
}
