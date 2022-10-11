using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands
{
   [UnusedByCPA]
   public class VersionNumber : Command
   {
      [CommandParameter(0)] public int Version;
   }
}