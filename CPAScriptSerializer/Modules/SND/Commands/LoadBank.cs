using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands {

   public class LoadBank : Command
   {
      [CommandParameter(0)]
      public int BankIndex;
   }
}
