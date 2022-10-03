using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CHL {
   public class AddChannelName : Command
   {
      [CommandParameter(0)] public string ChannelName;
   }
}
