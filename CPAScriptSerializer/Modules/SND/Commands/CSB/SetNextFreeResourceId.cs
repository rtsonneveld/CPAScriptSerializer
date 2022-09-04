using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB
{
   [UnusedByCPA]
   public class SetNextFreeResourceId : Command
   {
      [CommandParameter(0)] public int NextFreeResourceId;
   }
}