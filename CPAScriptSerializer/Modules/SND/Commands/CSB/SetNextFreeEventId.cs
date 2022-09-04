using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB
{
   [UnusedByCPA]
   public class SetNextFreeEventId : Command
   {
      [CommandParameter(0)] public int NextFreeEventId;
   }
}