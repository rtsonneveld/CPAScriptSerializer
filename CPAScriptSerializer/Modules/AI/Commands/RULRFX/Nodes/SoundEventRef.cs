using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes
{
   public class SoundEventRef : NodeBase
   {
      [CommandParameter(0)] public CPAScriptReference<SndEventM> Value;
   }
}