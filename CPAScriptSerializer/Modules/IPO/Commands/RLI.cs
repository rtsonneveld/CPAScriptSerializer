using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.PO.Sections;

namespace CPAScriptSerializer.Modules.IPO.Commands {
   public class RLI : Command
   {
      [CommandParameter(0)] public string ParameterName;
      [CommandParameter(1)] public CPAScriptReference<ISI.Sections.ISI> InstanceSpecificInfo;
   }
}
