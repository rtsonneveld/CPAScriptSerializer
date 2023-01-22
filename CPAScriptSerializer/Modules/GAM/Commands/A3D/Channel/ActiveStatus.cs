using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Channel {

   [UnusedByCPA] // Editor datas
   public class ActiveStatus : Command
   {
      // TODO: 0/1 boolean
      [CommandParameter(0)] public byte IsActive;
   }
}
