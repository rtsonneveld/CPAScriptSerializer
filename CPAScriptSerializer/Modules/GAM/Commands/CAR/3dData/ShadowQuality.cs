﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections.STA;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR._3dData {
   public class ShadowQuality : Command
   {
      [CommandParameter(0)]
      public int Quality;
   }
}
