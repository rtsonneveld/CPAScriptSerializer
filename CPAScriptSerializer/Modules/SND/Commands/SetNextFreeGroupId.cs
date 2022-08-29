using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands {
   public class SetNextFreeGroupId : Command
   {
      [CommandParameter(0)]
      public int NextFreeGroupId;
   }
}
