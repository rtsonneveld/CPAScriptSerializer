using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.STA {
   public class Animation : Command
   {
      [CommandParameter(0)] public string AnimationName;
   }
}
