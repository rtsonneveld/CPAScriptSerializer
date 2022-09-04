using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetLoopData : Command {
      [CommandParameter(0)]
      public uint StartLoop;

      [CommandParameter(1)]
      public uint LoopLength;
   }
}
