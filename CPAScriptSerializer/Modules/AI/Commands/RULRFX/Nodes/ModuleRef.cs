using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dChannelNames;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
    public class ModuleRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<AddChannelName> Value;
   }
}