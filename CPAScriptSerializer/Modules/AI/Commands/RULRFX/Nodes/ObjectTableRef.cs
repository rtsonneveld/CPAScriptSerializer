using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class ObjectTableRef : NodeBase
   {
      /// <summary>
      /// Path to .tbl file
      /// </summary>
      [CommandParameter(0)] public string Value;
   }
}