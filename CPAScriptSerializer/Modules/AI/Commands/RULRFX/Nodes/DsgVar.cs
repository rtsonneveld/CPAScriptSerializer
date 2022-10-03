using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {

   // TODO: seems this is not used in R2, instead DsgVarRef is used - check older games?
   [UnusedByCPA]
   public class DsgVar : NodeBase
   {
      // DsgVar index? But there's also DsgVarId...
      [CommandParameter(0)] public int Value;
   }
}
