using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.LCB;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class LoadMap : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndMapE> Map;
   }
}
