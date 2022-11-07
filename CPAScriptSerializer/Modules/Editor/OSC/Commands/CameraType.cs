using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OSC.Commands {
   [UnusedByCPA]
   public class CameraType : Command
   {
      [CommandParameter(0)] public int Type; // Seemingly unused and always 0
   }
}
