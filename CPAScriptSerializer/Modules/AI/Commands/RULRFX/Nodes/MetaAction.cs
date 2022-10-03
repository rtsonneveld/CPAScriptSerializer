using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class MetaAction : NodeBase {
      [CommandParameter(0)] public EnumMetaAction Value;
   }
}