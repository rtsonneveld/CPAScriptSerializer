using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SPO.Commands.SuperObject {
   public class Transparency : Command
   {
      [CommandParameter(0)] public float SpoTransparency;
   }
}
