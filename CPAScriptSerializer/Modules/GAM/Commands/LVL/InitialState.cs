using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections.STA;

namespace CPAScriptSerializer.Modules.GAM.Commands.LVL {
   public class InitialState : Command
   {
      [CommandParameter(0)] public CPAScriptReference<CreateNewState> State;
   }
}
