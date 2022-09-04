using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndRandomElementM {
   public class SetElementCanBeChoosenTwice : Command {

      [CommandParameter(0)] public bool CanBeChoosenTwice;
   }
}
