using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.LCB
{
   public class LoadEvent : Command
   {
      [CommandParameter(0)] public string EventName;
   }
}