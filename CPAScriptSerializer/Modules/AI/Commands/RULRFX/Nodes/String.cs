using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class String : NodeBase
   {
      [CommandParameter(0)] public string Value;
   }
}