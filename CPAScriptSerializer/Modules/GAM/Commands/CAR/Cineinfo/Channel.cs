﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class Channel : Command
   {
      [CommandParameter(0)] public int ChannelIndex;
   }
}
