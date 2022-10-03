using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Mask : NodeBase
   {
      [CommandParameter(0)] public uint Value;
   }
}