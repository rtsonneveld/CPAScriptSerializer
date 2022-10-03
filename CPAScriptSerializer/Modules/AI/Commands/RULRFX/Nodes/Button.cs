using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Button : NodeBase
   {
      [CommandParameter(0)] public string ButtonName;
   }
}