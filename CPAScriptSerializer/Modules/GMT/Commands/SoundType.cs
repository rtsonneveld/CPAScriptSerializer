using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GMT.Commands {
   public class SoundType : Command
   {
      [CommandParameter(0)] public int Type;
   }
}
