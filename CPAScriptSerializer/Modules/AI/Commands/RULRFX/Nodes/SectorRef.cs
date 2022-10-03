using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class SectorRef : NodeBase
   {
      // For some reason SectorRef also references a SuperObject
      [CommandParameter(0)] public CPAScriptReference<SuperObject> Value;
   }
}