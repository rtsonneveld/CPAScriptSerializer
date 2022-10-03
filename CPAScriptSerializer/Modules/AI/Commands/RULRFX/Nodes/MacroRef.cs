using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.MAC;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class MacroRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<CreateMacro> Value;
   }
}