using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetLoopLength : Command {
      [CommandParameter(0)]
      public uint LoopLength;
   }
}
