using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Enums;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB
{
    public class SetTransitionType : Command
    {
       [CommandParameter(0)] public EnumTransitionType TransitionType;
    }
}
