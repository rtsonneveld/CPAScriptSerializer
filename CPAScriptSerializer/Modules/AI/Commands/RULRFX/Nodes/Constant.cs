using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Constant : NodeBase
   {
      [CommandParameter(0)] public int Value;
   }
}