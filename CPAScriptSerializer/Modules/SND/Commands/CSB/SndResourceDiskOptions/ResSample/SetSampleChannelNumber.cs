using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetSampleChannelNumber : Command {
      [CommandParameter(0)]
      public uint SampleChannelNumber;
   }
}
