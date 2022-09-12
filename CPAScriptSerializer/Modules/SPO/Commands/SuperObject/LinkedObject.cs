using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.SuperObject {
   public class LinkedObject : Command
   {
      [CommandParameter(0)] public CPAScriptReference<Sections.SuperObject> ObjectRef;
   }
}
