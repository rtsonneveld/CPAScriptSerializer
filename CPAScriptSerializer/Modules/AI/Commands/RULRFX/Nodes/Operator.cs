using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class Operator : NodeBase
   {
      [CommandParameter(0)] public EnumOperator Value;
   }
}
