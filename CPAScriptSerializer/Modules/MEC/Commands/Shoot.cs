using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.MEC.Commands {
   public class Shoot : Command
   {
      [CommandParameter(0)] public int Enable;
   }
}
