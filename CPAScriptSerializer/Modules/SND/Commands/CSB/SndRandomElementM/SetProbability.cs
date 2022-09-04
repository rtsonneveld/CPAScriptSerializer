using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndRandomElementM {
   public class SetProbability : Command
   {
      [CommandParameter(0)] public float Probability;
   }
}
