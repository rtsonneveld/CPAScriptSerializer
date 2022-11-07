using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.ENL
{
    public class AddName : Command
    {
        [CommandParameter(0)] public string Name;
        [CommandParameter(1)] public EnumShareMode ShareMode;
    }
}
