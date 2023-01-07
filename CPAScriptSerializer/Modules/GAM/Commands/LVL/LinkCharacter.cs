using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections.CAR;

namespace CPAScriptSerializer.Modules.GAM.Commands.LVL {
   public class LinkCharacter : Command
   {
      [CommandParameter(0)]
      public CPAScriptReference<Character> CharacterReference;
   }
}
