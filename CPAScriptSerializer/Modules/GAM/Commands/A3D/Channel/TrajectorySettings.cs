using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Channel
{

    [UnusedByCPA]
    public class TrajectorySettings : Command
    {
        // Unused, 'Editor datas' according to MakeAnim
        [CommandParameter(0)] public int Param0;
        [CommandParameter(1)] public int Param1;
        [CommandParameter(2)] public int Param2;
        [CommandParameter(3)] public int Param3;
        [CommandParameter(4)] public int Param4;
        [CommandParameter(5)] public int Param5;
        [CommandParameter(6)] public int Param6;
    }
}
