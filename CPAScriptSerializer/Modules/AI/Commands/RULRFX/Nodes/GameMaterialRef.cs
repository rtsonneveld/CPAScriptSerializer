using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Sections;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class GameMaterialRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<GameMaterial> Value;
   }
}