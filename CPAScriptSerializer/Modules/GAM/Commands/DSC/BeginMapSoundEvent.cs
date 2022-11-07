using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Sections.CSB;

namespace CPAScriptSerializer.Modules.GAM.Commands.DSC {
   public class BeginMapSoundEvent : Command
   {
      [CommandParameter(0)] public CPAScriptReference<SndEventM> SoundEvent;
   }
}
