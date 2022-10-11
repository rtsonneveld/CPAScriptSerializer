using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.TBL_HEADER {
   public class VersionNumber : Command
   {
      [CommandParameter(0)] public int Version;
   }
}
