using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.IPT.Commands.Input {
   public class JoyOrPadCommand : Command
   {

      public const string JoyOrPadJustPressed = "JoyOrPadJustPressed";
      public const string JoyOrPadJustReleased = "JoyOrPadJustReleased";
      public const string JoyOrPadPressed = "JoyOrPadPressed";
      public const string JoyOrPadReleased = "JoyOrPadReleased";

      [CommandParameter(0)] public int PadNumber;
      [CommandParameter(1)] public EnumJoyPadButton PadAction;
      [CommandParameter(2)] public byte? MinCounterInput = null;
      [CommandParameter(3)] public byte? MaxCounterInput = null;
   }
}
