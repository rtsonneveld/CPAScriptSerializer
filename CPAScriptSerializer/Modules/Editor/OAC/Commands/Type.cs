using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands
{
   public class Type : Command
   {
      [CommandParameter(0)] public EnumModelType ModelType;
   }
}