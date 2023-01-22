using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.Speed {
   public class RotationSpeed : Command
   {
      [CommandParameter(0)] public int Value;
   }
}
