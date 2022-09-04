using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSample {
   public class SetFlags : Command {
      [CommandParameter(0)]
      public bool Pitchable;

      [CommandParameter(1)]
      public bool Volable;

      [CommandParameter(2)]
      public bool Panable;

      [CommandParameter(3)]
      public bool Spacable;

      [CommandParameter(4)]
      public bool Reverbable;

      [CommandParameter(5)]
      public bool Stream;
   }
}
