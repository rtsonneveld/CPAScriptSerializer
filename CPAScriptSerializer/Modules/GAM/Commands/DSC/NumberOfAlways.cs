using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class NumberOfAlways : Command
   {
      [CommandParameter(0)] public int NumAlways;
   }
}
