using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class InitInputDeviceManager : Command
   {
      [CommandParameter(0)] public int HistorySize;
   }
}
