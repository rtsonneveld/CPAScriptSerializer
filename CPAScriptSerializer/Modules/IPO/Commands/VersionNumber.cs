using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPO.Commands {

   [UnusedByCPA]
   public class VersionNumber : Command
   {
      [CommandParameter(0)] public int Version;
   }
}
