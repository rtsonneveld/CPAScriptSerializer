using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.SuperObject {
   public class Flags : Command
   {
      [CommandParameter(0)] public uint SpoFlags;
   }
}
