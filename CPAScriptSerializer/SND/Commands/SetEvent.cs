using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class SetEvent : Command
   {
      [ParameterSettings(0)]
      public string EventName;

      [ParameterSettings(1)]
      public ulong BankId;

      [ParameterSettings(2)]
      public ulong Pos;
   }
}
