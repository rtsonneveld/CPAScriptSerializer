using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetSampleResolution : Command {
      [CommandParameter(0)]
      public uint SampleResolution;
   }
}
