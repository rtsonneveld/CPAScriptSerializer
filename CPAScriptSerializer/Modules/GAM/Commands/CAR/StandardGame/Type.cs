using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   public class Type : Command
   {
      [CommandParameter(0)] public string FamilyName;
      [CommandParameter(1)] public string AIModelName;
      [CommandParameter(2)] public string InstanceName;
   }
}
