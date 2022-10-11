using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.PO.Commands {

   // Collide set
   public class CS : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Modules.Editor.OZO.Sections.CS> CollideSet;
   }
}
