using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Key
{
    public class Attribute : Command
    {
        [CommandParameter(0)]
        public EnumKeyAttribute KeyType;
    }
}
