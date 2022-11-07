using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TAC.Sections;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.ENL
{
    public class ZAList : Command
    {
        [CommandParameter(0)]
        public CPAScriptReference<CreateNewArrayOfZoneSet> ZoneList;
    }
}
