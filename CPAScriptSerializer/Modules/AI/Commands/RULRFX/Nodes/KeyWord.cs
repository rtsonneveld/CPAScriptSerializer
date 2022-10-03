using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class KeyWord : NodeBase
   {
      [CommandParameter(0)] public EnumKeyWord Value;
   }
}