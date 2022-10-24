﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.Cineinfo {
   public class ShiftTarget : Command
   {
      [CommandParameter(0)] public float X;
      [CommandParameter(1)] public float Y;
      [CommandParameter(2)] public float Z;
   }
}
