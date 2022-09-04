using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetSampleFrequency : Command {
      [CommandParameter(0)]
      public uint SampleFrequency;
   }
}
