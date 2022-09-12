using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles {
   public class AddUV : Command
   {
      [CommandParameter(0)] public int Index;
      [CommandParameter(1)] public float U;
      [CommandParameter(2)] public float V;

   }
}
