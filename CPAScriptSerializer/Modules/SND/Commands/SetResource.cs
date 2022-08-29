using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands
{
   public class SetResource : Command
   {
      [CommandParameter(0)] public string ResourceName;

      [CommandParameter(1)] public ulong BankId;

      [CommandParameter(2)] public ulong Pos;
   }
}