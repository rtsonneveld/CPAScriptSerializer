using CPAScriptSerializer.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSwitch {
   public class SetMaintainIfSwitched : Command 
   {
      [CommandParameter(0)]
      public bool MaintainIfSwitched;
   }
}
