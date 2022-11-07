using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class FrameSynchro : Command
   {
      [CommandParameter(0)] public EnumOnOffToggle OnOff;
      [CommandParameter(1)] public int NumFrames; // "NbTrame (0 for hysteresis system)"
      [CommandParameter(2)] public int PctLowLimit; // "Percent use to decrease NbTrame"
   }
}
