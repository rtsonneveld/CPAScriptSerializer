using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.WAY
{
   public class WpSommetWaypoint : Command
   {
      [CommandParameter(0)] public int Weight;
      /// <summary>
      /// A string of 32 0 or 1 characters, to indicate bits
      /// TODO: Create a special type for this
      /// </summary>
      [CommandParameter(1)] public string Capabilities;
   }
}