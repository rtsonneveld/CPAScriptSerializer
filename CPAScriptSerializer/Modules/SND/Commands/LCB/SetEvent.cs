using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND.Commands.LCB
{
   public class SetEvent : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndEventM> EventRef;

      [CommandParameter(1)] public ulong BankId;

      [CommandParameter(2)] public ulong Pos;
   }
}