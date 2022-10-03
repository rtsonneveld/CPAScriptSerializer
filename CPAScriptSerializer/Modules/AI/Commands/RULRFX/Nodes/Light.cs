using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Light : NodeBase
   {
      // TODO: make this a reference
      [CommandParameter(0)] public string Value;
   }
}