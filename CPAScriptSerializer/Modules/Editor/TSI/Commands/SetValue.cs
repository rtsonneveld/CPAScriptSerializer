﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.TSI.Commands {
   public class SetValue : Command
   {
      [CommandParameter(0)] public int Value;
   }
}
