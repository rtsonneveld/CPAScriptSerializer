using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme {
   public class SetFadeDuration : Command {
      [CommandParameter(0)]
      public double FadeDuration;
   }
}
