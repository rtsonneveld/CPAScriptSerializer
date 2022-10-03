using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class SuperObjectRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<SuperObject> Value;
   }
}