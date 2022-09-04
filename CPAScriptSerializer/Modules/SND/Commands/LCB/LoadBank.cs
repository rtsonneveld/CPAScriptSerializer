using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.LCB
{
   public class LoadBank : Command
   {
      [CommandParameter(0)] public int BankIndex;
   }
}