using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TGM.Sections;

namespace CPAScriptSerializer.Modules.GMT.Commands {

   public class MechanicalMat : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<MechanicalMaterial> MechanicalMaterialRef;
   }
}
