﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class Speed : Command
   {
      [CommandParameter(0)] public byte Value;
   }
}
