using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class ComportRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<CreateComport> Value;
   }
}