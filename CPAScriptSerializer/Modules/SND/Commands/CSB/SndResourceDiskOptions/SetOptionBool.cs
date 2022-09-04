using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions {
   public class SetOptionBool : Command {
      [CommandParameter(0)]
      public bool Value;
   }
}
