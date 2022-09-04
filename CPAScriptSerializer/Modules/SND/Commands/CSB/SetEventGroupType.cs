using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB
{
   [UnusedByCPA]
   public class SetEventGroupType : Command
   {
      [CommandParameter(0)] public string EventGroupType;
   }
}