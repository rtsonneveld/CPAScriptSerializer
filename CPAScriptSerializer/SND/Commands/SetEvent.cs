using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class SetEvent : Command
   {
      public string EventName;
      public ulong BankId;
      public ulong Pos;

      public override void Fill(Parameter[] parameters)
      {
         EventName = parameters[0];
         BankId = parameters[1];
         Pos = parameters[2];
      }
   }
}
