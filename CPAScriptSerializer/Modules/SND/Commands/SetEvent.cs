using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands
{
   public class SetEvent : Command
   {
      [CommandParameter(0)] public string EventName;

      [CommandParameter(1)] public ulong BankId;

      [CommandParameter(2)] public ulong Pos;
   }
}