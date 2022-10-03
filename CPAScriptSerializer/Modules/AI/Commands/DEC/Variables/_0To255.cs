using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC.Variables {
   public class _0To255 : VariableBase
   {
      public const string CommandName = "0To255";
      public override string ExportName => CommandName;

      [CommandParameter(2)] public byte Value;
   }
}
