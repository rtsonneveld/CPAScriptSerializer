﻿using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.LCB
{
   public class SetDefaultLanguage : Command
   {
      [CommandParameter(0)] public string Language;
   }
}