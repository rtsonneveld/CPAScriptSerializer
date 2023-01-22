using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.A3dChannelNames
{
    public class AddChannelName : Command
    {
        [CommandParameter(0)] public string ChannelName;
    }
}
