using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GMT.Enums;

namespace CPAScriptSerializer.Modules.GMT.Commands.Material {
   public class Backface : Command
   {
      [CommandParameter(0)] public EnumOnOffToggle BackFaceToggle;
   }
}
