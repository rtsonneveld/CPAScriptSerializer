using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResRandom {
   public class SetProbNothing : Command
   {
      /// <summary>
      /// The probability that no sound will be chosen
      /// </summary>
      [CommandParameter(0)] public float ProbNothing;
   }
}
