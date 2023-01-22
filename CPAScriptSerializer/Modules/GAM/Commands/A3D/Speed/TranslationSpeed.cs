using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Speed {
   public class TranslationSpeed : Command
   {
      [CommandParameter(0)] public int Value;
   }
}
