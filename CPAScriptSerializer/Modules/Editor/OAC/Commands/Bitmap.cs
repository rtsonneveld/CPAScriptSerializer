﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands
{
   public class Bitmap : Command
   {
      [CommandParameter(0)] public string Filename;
   }
}