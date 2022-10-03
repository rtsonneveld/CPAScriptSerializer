using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class TextRef : NodeBase
   {
      [CommandParameter(0)] public string Value;
   }
}