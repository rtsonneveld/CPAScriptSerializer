using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class CapsRef : NodeBase
   {
      /// <summary>
      /// A string of 32 0 or 1 characters, to indicate bits
      /// TODO: Create a special type for this
      /// </summary>
      [CommandParameter(0)] public string Value;
   }
}