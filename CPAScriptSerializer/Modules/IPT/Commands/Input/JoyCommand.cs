using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.IPT.Commands.Input {
   public class JoyCommand : Command {
      public const string JoyJustPressed = "PadJustPressed";
      public const string JoyJustReleased = "PadJustReleased";
      public const string JoyPressed = "PadPressed";
      public const string JoyReleased = "PadReleased";

      [CommandParameter(0)] public int JoyNumber;
      [CommandParameter(1)] public EnumJoyPadButton JoyButton;
      [CommandParameter(2)] public byte? MinCounterInput = null;
      [CommandParameter(3)] public byte? MaxCounterInput = null;
   }
}
