using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OZO.Commands {
   public class VersionNumber : Command
   {
      [CommandParameter(0)] public int Version;
   }
}
