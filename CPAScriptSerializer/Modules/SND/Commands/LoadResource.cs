using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands {

   public class LoadResource : Command
   {
      [CommandParameter(0)]
      public string ResourcePath;
   }
}
