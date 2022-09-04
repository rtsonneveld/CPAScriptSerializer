using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme {
   public class SetParameters : Command {
      [CommandParameter(0)]
      public uint NbParts;

      [CommandParameter(1)]
      public uint StartLoop;
   }
}
