using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.General {
   public class SetVolume : Command
   {
      [CommandParameter(0)] public byte Volume;
   }
}
