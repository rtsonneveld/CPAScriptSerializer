using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame
{
    public class PivotPosition : Command
    {
        [CommandParameter(0)] public short VertexIndex;
    }
}
