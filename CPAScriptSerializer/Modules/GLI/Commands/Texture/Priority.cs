using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class Priority : Command
   {
      [CommandParameter(0)] public EnumPriority TexturePriority;
   }
}
