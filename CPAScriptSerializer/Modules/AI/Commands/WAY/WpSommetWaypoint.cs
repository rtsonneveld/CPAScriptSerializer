using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.WAY
{
   public class WpSommetWaypoint : Command
   {
      [CommandParameter(0)] public int Weight;
      [CommandParameter(1)] public uint Capabilities;
   }
}