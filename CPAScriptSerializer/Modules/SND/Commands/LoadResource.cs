using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND.Commands
{
   public class LoadResource : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndResourceM> ResourcePath;
   }
}