using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.General {
   public class SetFileName : Command {
      // Maximum 12 characters
      [CommandParameter(0)] public string FileName;
   }
}
