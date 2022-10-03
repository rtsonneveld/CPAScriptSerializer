using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Enums;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Color : NodeBase
   {
      [CommandParameter(0)] public uint Value;
   }
}