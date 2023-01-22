using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame
{

    // Unused but including it just because
    [UnusedByCPA]
    public class IncludingBox : Command
    {
        [CommandParameter(0)] public int VertexRefStart;
        [CommandParameter(1)] public int VertexRefEnd;
    }
}
