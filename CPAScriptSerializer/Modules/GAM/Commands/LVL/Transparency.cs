using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.LVL {
   public class Transparency : Command
   {
      [CommandParameter(0)]
      public float Value;
   }
}
