using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.PO.Sections;

namespace CPAScriptSerializer.Modules.IPO.Commands {
   public class PO : Command
   {
      [CommandParameter(0)] public CPAScriptReference<PHY> PhysicalObject;
   }
}
