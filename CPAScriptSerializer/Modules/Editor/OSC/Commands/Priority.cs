using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   public class Priority : Command
   {
      [CommandParameter(0)] public byte Value;
   }
}
