using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB
{
   public class ScriptVersion : Command
   {
      [CommandParameter(0)] public int Version;
   }
}