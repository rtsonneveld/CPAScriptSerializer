using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Devices {

   public class Pad : Command
   {
      [CommandParameter(0)]
      public int PadNum;
   }
}
