using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.GAM.Commands.LVL {
   public class CharacterFlags : Command
   {
      [CommandParameter(0)] public uint Flags;
   }
}
