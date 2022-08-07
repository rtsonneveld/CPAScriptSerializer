using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class SetResource : Command
   {
      [CommandParameter(0)]
      public string ResourceName;

      [CommandParameter(1)]
      public ulong BankId;

      [CommandParameter(2)]
      public ulong Pos;
   }
}
