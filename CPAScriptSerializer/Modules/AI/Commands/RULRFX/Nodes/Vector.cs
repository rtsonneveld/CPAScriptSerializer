using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Vector : NodeBase
   {
      [UnusedByCPA]
      [CommandParameter(0)] public string Unused; // Always filled with "Unused"
   }
}