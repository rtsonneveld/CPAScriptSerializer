using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class RealRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<AI.RealRef> Value;
   }
}