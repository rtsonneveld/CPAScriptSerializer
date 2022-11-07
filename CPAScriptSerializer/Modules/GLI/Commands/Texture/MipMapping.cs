using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GLI.Commands.Texture {
   public class MipMapping : Command
   {
      [CommandParameter(0)] public EnumMipMapping EnableMipMapping;
   }
}
