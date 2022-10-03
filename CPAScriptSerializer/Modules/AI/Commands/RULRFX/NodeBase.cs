using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX {
   public class NodeBase : Command
   {
      [CommandParameter(1)] public byte Depth;
   }
}
