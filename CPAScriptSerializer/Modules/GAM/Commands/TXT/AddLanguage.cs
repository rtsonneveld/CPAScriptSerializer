using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TXT {
   public class AddLanguage : Command
   {
      [CommandParameter(0)] public string LanguageCode;
      [CommandParameter(1)] public string LanguageText;
   }
}
