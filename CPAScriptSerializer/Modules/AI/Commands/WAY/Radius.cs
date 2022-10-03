using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.WAY
{
   public class Radius : Command
   {
      [CommandParameter(0)] public float WpRadius;
   }
}