using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSwitch {
   public class SetNumberOfElements : Command {
      [CommandParameter(0)]
      public uint NumberOfElements;
   }
}
