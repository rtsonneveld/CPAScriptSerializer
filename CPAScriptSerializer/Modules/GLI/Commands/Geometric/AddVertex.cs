using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GLI.Commands.Geometric
{
   public class AddVertex : Command
   {
      [CommandParameter(0)] public int Index;

      [CommandParameter(1)] public float PointX;
      [CommandParameter(2)] public float PointY;
      [CommandParameter(3)] public float PointZ;


      [CommandParameter(4)] public float NormalX;
      [CommandParameter(5)] public float NormalY;
      [CommandParameter(6)] public float NormalZ;

      // These fields are written but never read (d_stListOfPointsReceivedLightIntensity)
      [UnusedByCPA] [CommandParameter(7)] public float ColorRed;
      [UnusedByCPA] [CommandParameter(8)] public float ColorGreen;
      [UnusedByCPA] [CommandParameter(9)] public float ColorBlue;
   }
}