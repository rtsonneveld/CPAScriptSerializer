using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Enums;

namespace CPAScriptSerializer.Modules.GMT.Commands.Material {
   public class Type : Command
   {
      [CommandParameter(0)]
      public EnumMaterialType MaterialType;
   }
}
