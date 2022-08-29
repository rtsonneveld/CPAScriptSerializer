using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.IPT.Commands {
   public class AddRef : Command
   {
      [CommandParameter(0)] public string RefText;
      [CommandParameter(1)] public EnumRefType RefType;
   }
}
