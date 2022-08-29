using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Commands {

   public class Vertex : Command {

      [CommandParameter(0)] public float PosX;
      [CommandParameter(1)] public float PosY;
      [CommandParameter(2)] public float PosZ;
   }
}
