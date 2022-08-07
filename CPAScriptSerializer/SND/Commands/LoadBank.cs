using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class LoadBank : Command
   {
      public int BankIndex;

      public override void Fill(Parameter[] parameters)
      {
         BankIndex = parameters[0];
      }
   }
}
