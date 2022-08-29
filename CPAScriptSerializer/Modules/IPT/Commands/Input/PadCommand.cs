using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.IPT.Commands.Input {
   public class PadCommand : Command {
      public const string PadJustPressed = "PadJustPressed";
      public const string PadJustReleased = "PadJustReleased";
      public const string PadPressed = "PadPressed";
      public const string PadReleased = "PadReleased";

      [CommandParameter(0)] public int PadNumber;
      [CommandParameter(1)] public EnumJoyPadButton PadButton;
      [CommandParameter(2)] public byte? MinCounterInput = null;
      [CommandParameter(3)] public byte? MaxCounterInput = null;
   }
}
