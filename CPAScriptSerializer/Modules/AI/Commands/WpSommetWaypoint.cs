using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands
{
   public class WpSommetWaypoint : Command
   {
      [CommandParameter(0)] public int Weight;
      [CommandParameter(1)] public uint Capabilities;
   }
}