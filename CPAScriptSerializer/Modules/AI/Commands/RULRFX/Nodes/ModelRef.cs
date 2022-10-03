using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.AI;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class ModelRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<CreateAIModel> Value;
   }
}