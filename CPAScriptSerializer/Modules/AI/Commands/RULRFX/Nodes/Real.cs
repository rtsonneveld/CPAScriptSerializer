using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Real : NodeBase
   {
      [CommandParameter(0)] public float Value;
   }
}