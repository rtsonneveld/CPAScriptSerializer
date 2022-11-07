using CPAScriptSerializer.Modules.GAM.Commands.DSC;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Sections.DSC {
   internal class BinaryUse : CPAScriptSection {
      public BinaryUse(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(UseA3b), typeof(UseA3b) },
         { nameof(UseBinaryMod), typeof(UseBinaryMod) },
         { nameof(UseBinaryData), typeof(UseBinaryData) },
      };
   }
}
