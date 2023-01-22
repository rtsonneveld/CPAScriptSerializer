using CPAScriptSerializer.Commands;

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