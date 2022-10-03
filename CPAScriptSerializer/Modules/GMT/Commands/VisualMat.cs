using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GMT.Commands {
   public class VisualMat : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<Sections.Material> VisualMaterialRef;
   }
}
