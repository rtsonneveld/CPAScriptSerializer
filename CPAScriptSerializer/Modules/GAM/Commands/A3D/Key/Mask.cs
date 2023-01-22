using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Key
{
    public class Mask : Command
    {
        [CommandParameter(0)] public short Vertex0;
        [CommandParameter(1)] public short Vertex1;
        [CommandParameter(2)] public short Vertex2;
    }
}
