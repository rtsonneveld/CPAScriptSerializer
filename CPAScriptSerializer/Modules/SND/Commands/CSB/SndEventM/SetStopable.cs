using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndEventM {
   /* Stopable (sic) :) */
   public class SetStopable : Command
   {
      [CommandParameter(0)] public bool Stopable;
   }
}
