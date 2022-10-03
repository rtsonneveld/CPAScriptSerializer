using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class Procedure : NodeBase
   {
      [CommandParameter(0)] public EnumProcedure Value;
   }
}
