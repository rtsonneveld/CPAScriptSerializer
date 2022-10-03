using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Condition : NodeBase
   {
      [CommandParameter(0)] public EnumCondition Value;
   }
}