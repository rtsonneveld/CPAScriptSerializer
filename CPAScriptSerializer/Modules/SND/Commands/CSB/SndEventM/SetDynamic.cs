using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndEventM {

   public class SetDynamic : Command
   {
      [CommandParameter(0)] public bool Dynamic;
   }
}
