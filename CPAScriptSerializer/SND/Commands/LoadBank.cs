﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class LoadBank : Command
   {
      [ParameterSettings(0)]
      public int BankIndex;
   }
}
