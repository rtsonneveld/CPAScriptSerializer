using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {
   public class SetDefaultLanguage : Command
   {
      [ParameterSettings(0)]
      public string Language;
   }
}
