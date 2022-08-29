using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Input {
   
   public class ActionCommand : Command {

      public const string ActionJustValidated = "ActionJustValidated";
      public const string ActionJustInvalidated = "ActionJustInvalidated";
      public const string ActionValidated = "ActionValidated";
      public const string ActionInvalidated = "ActionInvalidated";

      [CommandParameter(0)] public string Action;
      [CommandParameter(1)] public byte? MinCounterInput = null;
      [CommandParameter(2)] public byte? MaxCounterInput = null;
   }
}
