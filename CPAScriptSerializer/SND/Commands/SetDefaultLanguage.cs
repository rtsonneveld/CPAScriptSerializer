using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {
   public class SetDefaultLanguage : Command
   {
      public string Language;

      public override void Fill(Parameter[] parameters)
      {
         if (parameters.Length > 0) {
            Language = parameters[0];
         }
      }
   }
}
