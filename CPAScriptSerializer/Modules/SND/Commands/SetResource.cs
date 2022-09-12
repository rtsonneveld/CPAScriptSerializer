using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND.Commands
{
   public class SetResource : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndResourceM> ResourceRef;

      [CommandParameter(1)] public ulong BankId;

      [CommandParameter(2)] public ulong Pos;
   }
}