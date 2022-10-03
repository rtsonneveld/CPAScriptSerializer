using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes {

   // TODO: seems this is not used in R2, instead DsgVarRef is used - check older games?
   public class DsgVarId : NodeBase
   {
      // DsgVar index? But then what about DsgVar.cs?
      [CommandParameter(0)] public int Value;
   }
}
