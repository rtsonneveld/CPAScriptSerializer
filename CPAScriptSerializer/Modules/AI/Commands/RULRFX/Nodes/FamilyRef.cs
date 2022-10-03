using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class FamilyRef : NodeBase
   {
      /// <summary>
      /// Family Name
      /// </summary>
      [CommandParameter(0)] public string Value;
   }
}