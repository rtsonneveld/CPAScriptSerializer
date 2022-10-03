using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class ConstantRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<AI.ConstantRef> Value;
   }
}