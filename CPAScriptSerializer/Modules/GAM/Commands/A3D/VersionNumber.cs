using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D {

   [UnusedByCPA]
   public class VersionNumber : Command
   {
      [CommandParameter(0)] public int Version;
   }
}
