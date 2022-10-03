using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC {
   public class TypeSaveVariable : Command
   {
      [CommandParameter(0)] public int VariableIndex;
      [CommandParameter(1)] public EnumDsgVarSaveType SaveType;
   }
}
