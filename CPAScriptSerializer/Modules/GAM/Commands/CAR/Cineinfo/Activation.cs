using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class Activation : Command
   {
      // TODO: 0/1 boolean
      [CommandParameter(0)] public int IsActive;
   }
}
