using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.CutPointsList {

   [UnusedByCPA] // Only used in an old rayman animation (ry_fin_map)
   public class CutPoint : Command
   {
      [CommandParameter(0)] public int Param0;
      [CommandParameter(1)] public int Param1;
      [CommandParameter(2)] public int Param2;
   }
}
