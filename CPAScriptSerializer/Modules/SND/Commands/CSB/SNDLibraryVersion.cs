using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB
{
   public class SNDLibraryVersion : Command
   {
      [CommandParameter(0)] public string Version;
   }
}