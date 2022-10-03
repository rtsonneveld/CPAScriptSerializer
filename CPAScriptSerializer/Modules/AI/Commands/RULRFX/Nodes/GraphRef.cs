using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class GraphRef : NodeBase
   {
      // TODO: can't find any examples of this, maybe in old games?
      [CommandParameter(0)] public CPAScriptReference<WPGraph> Value;
   }
}