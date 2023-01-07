using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Commands.DSC;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   public class InputDeviceManagerDescription : CPAScriptSection {
      public InputDeviceManagerDescription(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(InitInputDeviceManager), typeof(InitInputDeviceManager)},
         {nameof(AddInputDeviceFile), typeof(AddInputDeviceFile)},
         {nameof(Computetable), typeof(Computetable)},
      };
   }
}
