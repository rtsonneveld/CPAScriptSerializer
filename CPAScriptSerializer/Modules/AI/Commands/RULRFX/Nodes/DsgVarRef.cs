using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.DEC;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class DsgVarRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<CreateVariables> Value;
   }
}
