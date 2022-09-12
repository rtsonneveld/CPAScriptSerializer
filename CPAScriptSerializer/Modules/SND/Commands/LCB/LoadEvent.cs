using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.SND.Commands.LCB
{
   public class LoadEvent : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndEventE> EventName;
   }
}