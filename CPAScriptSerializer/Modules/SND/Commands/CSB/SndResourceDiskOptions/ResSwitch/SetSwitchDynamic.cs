using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSwitch {
   public class SetSwitchDynamic : Command {

      [CommandParameter(0)]
      public bool SwitchDynamic;
   }
}
