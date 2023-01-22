using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Frame
{

    // Not used
    [UnusedByCPA]
    public class Object : Command
    {
        [CommandParameter(0)] public int ObjectIndex; // Reference to StringTable (name of object)
    }
}
