using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SND.Commands.CSB;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndEventM;
using CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.ResSwitch;

namespace CPAScriptSerializer.Modules.SND.Sections.CSB {
   public class SndSwitchListM : CPAScriptSection {
      public SndSwitchListM(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(SndSwitchElementM), typeof(SndSwitchElementM)},
         {nameof(SwitchInfoType), typeof(SwitchInfoType)},
         {nameof(SetInfoType), typeof(SetInfoType)},
         {nameof(SoundInfoType), typeof(SoundInfoType)},
         {nameof(SwitchDefaultValue), typeof(SwitchDefaultValue)},
         {nameof(SetSwitchDynamic), typeof(SetSwitchDynamic)},
         {nameof(SetMaintainIfSwitched), typeof(SetMaintainIfSwitched)},
         {nameof(SetDynamic), typeof(SetDynamic)},
         {nameof(SetDefaultValue), typeof(SetDefaultValue)},
      };
   }
}
