using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TXT {
   public class NewString : Command
   {
      [CommandParameter(0)] public string Code;
      [CommandParameter(1)] public string Text;
   }
}
