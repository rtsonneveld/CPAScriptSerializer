using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections.CAR;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {
   public class PersoRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<Character> Value;
   }
}
