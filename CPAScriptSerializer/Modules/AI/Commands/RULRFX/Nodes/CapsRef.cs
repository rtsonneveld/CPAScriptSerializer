using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class CapsRef : NodeBase
   {
      [CommandParameter(0)] public uint Value;
   }
}