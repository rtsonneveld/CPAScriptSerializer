using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OZO.Sections;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.ENL
{
    public class ObjectsList : Command
    {
        [CommandParameter(0)]
        public CPAScriptReference<CreateNewArrayOfZdx> List;
    }
}
