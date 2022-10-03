using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class WayPoint : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<Waypoint> Value;
   }
}
