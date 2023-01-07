using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.StandardGame {
   public class Capabilities : Command
   {
      /// <summary>
      /// A string of 32 0 or 1 characters, to indicate bits
      /// TODO: Create a special type for this (capabilities/bits)
      /// </summary>
      [CommandParameter(0)] public string Value;
   }
}
