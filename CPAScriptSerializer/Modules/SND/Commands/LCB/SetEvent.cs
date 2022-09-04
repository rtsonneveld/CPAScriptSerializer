using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.LCB
{
   public class SetEvent : Command
   {
      [CommandParameter(0)] public string EventName;

      [CommandParameter(1)] public ulong BankId;

      [CommandParameter(2)] public ulong Pos;
   }
}