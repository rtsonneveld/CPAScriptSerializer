﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.MSSound {
   public class SaturationDistance : Command
   {
      [CommandParameter(0)]
      public int Distance;
   }
}
