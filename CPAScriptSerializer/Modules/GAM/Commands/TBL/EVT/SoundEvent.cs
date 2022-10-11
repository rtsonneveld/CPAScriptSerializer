using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.EVT {
   public class SoundEvent : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndEventM> SoundEventReference;
   }
}
