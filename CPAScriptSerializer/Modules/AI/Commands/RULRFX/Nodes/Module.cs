using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.CHL;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class Module : NodeBase
   {
      /// <summary>
      /// Channel Index
      /// </summary>
      [CommandParameter(0)] public int Value;
   }
}