using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Input {
   public class KeyCommand : Command
   {
      public const string KeyPressed = "KeyPressed";
      public const string KeyReleased = "KeyReleased";
      public const string KeyJustPressed = "KeyJustPressed";
      public const string KeyJustReleased = "KeyJustReleased";

      [CommandParameter(0)] public string Key;
      [CommandParameter(1)] public int? MinCounterInput = null;
      [CommandParameter(2)] public int? MaxCounterInput = null;
   }
}
