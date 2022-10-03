using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class Function : NodeBase
   {
      [CommandParameter(0)] public EnumFunction Value;
   }
}
