using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class SetResource : Command
   {
      [ParameterSettings(0)]
      public string ResourceName;

      [ParameterSettings(1)]
      public ulong BankId;

      [ParameterSettings(2)]
      public ulong Pos;
   }
}
