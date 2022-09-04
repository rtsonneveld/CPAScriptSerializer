using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResTheme {
   public class SetNbMainLoop : Command {
      [CommandParameter(0)]
      public uint NbLoops;
   }
}
