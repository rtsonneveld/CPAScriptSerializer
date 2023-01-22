using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame
{
    public class Scale : Command
    {
        [CommandParameter(0)] public short QuaternionIndex;
        [CommandParameter(1)] public short VertexIndex;
    }
}
