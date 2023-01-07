using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPT.Commands.Devices;

namespace CPAScriptSerializer.Modules.IPT.Sections {
   public class ActivateDevices : CPAScriptSection {
      
      public ActivateDevices(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Keyboard), typeof(Keyboard) },
         { "KeyBoard", typeof(Keyboard) },
         { nameof(Pad), typeof(Pad) },
         { nameof(Joystick), typeof(Joystick) },
      };

      
   }
}
