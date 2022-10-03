using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class _32768To32767 : VariableBase
   {
      [CommandParameter(2)] public short Value;
   }
}
