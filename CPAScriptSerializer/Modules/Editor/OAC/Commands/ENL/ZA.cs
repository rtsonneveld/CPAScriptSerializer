using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TAC.Sections;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.ENL
{
    public class ZA : Command
    {
        [CommandParameter(0)]
        public CPAScriptReference<NewActivationZone> ActivationZone;
    }
}
