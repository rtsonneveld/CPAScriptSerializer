using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResRandom {
   public class SetNumberOfElements : Command {
      [CommandParameter(0)]
      public uint NbElements;
   }
}
