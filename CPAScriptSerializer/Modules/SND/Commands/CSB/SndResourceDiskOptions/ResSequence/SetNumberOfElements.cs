using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSequence {
   public class SetNumberOfElements : Command
   {
      [CommandParameter(0)] public int NumberOfElements;
   }
}
