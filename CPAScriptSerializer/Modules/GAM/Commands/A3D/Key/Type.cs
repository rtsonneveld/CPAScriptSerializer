using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Key {

   [UnusedByCPA] // Can't find this being parsed anywhere - possibly newer animation format?
   public class Type : Command
   {
      [CommandParameter(0)] public int Param0;
      [CommandParameter(1)] public int Param1;
      [CommandParameter(2)] public int Param2;
   }
}
