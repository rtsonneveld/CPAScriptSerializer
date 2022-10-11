using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.EVT {
   public class Period : Command
   {
      [CommandParameter(0)] public int Value; // Number of loops after FirstCall
   }
}
