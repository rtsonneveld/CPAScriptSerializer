using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections.STA;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class ActionRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<CreateNewState> Value;
   }
}
