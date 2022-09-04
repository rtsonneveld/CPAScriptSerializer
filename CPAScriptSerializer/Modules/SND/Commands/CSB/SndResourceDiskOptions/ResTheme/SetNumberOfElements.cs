using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme {
   public class SetNumberOfElements : Command {
      [CommandParameter(0)]
      public uint NbParts;
   }
}
