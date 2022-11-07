using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.TGM.Sections;

namespace CPAScriptSerializer.Modules.GMT.Commands {
   public class CollideMat : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<CollideMaterial> CollideMaterialRef;
   }
}
