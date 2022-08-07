using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class SetEvent : Command
   {
      [CommandParameter(0)]
      public string EventName;

      [CommandParameter(1)]
      public ulong BankId;

      [CommandParameter(2)]
      public ulong Pos;
   }
}
