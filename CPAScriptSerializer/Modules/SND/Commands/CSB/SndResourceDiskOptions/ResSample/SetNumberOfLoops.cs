using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetNumberOfLoops : Command {
      [CommandParameter(0)]
      public uint NumberOfLoops;
   }
}
