using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.A3D.DeformationFrame {
   public class DeformationLink : Command
   {
      [CommandParameter(0)] public int Param0;
      [CommandParameter(1)] public int Param1;
      [CommandParameter(2)] public int Param2;
      [CommandParameter(3)] public int Param3;
   }
}
