using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetStartLoop : Command {
      [CommandParameter(0)]
      public uint StartLoop;
   }
}
