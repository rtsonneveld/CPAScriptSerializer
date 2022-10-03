using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.MEC.Commands {
   public class G : Command
   {
      [CommandParameter(0)] public float Value;
   }
}
