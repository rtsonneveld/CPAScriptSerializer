using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles {
   public class AddFaceUV : Command
   {
      [CommandParameter(0)] public int Index;

      [CommandParameter(1)] public int PointIndex0;
      [CommandParameter(2)] public int PointIndex1;
      [CommandParameter(3)] public int PointIndex2;

      [CommandParameter(4)] public float NormalX;
      [CommandParameter(5)] public float NormalY;
      [CommandParameter(6)] public float NormalZ;

      [CommandParameter(7)] public int UVIndex0;
      [CommandParameter(8)] public int UVIndex1;
      [CommandParameter(9)] public int UVIndex2;

   }
}
