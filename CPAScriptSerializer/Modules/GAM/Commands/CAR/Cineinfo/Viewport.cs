using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class Viewport : Command
   {
      // TODO: make an enum for this that exports to a number value

      /// <summary>
      /// 	CAM_e_NoViewport = 0,
      /// 	CAM_e_MainViewport = 1,
      /// 	CAM_e_SecondaryViewport = 2
      /// </summary>
      [CommandParameter(0)] public int ViewportType;
   }
}
