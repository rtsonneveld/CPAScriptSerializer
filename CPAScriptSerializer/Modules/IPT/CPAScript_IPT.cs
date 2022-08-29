using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.IPT.Sections;

namespace CPAScriptSerializer.Modules.IPT
{
   public class CPAScript_IPT : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(InputAction), typeof(InputAction) },
         { nameof(Sequence), typeof(Sequence) },
         { nameof(ActivateDevices), typeof(ActivateDevices) },
         { nameof(KeyDefine), typeof(KeyDefine) },
         { nameof(IptLink), typeof(IptLink) },
      };
   }
}