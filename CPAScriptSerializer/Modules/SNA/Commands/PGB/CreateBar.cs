using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SNA.Commands.PGB {
   public class CreateBar : Command
   {
      [CommandParameter(0)] public int BarXMinPos;
      [CommandParameter(1)] public int BarYMinPos;
      [CommandParameter(2)] public int BarXMaxPos;
      [CommandParameter(3)] public int BarYMaxPos;
   }
}
