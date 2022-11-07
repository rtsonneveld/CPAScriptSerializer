using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class UseMemorySnapshot : Command
   {
      [CommandParameter(0)] public EnumLoadMode LoadMode;
   }
}
