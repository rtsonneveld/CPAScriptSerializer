using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND.Commands
{
   public abstract class LoadResource
   {
      public class LoadResourceE : Command {
         [CommandParameter(0)] public CPAScriptReference<SndResourceE> ResourcePath;
      }
      public class LoadResourceM : Command {
         [CommandParameter(0)] public CPAScriptReference<SndResourceM> ResourcePath;
      }
   }
}