using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Modules.IPT.Commands.Input {
   public class JoyAxeValue : Command
   {
      [CommandParameter(0)]
      public int JoyNumber;

      [CommandParameter(1)]
      public EnumJoyPadAxe JoyAction;

      [CommandParameter(2)]
      public int MinValue;

      [CommandParameter(3)]
      public int MaxValue;
   }
}
