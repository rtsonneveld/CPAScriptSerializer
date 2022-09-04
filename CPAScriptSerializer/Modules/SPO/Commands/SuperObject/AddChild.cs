using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.SuperObject {
   public class AddChild : Command
   {
      [CommandParameter(0)] public string ChildRef;
   }
}
