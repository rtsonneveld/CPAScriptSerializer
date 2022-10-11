﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPO.Sections;

namespace CPAScriptSerializer.Modules.IPO {
   public class CPAScript_IPO : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(IPO_HEADER), typeof(IPO_HEADER) },
         { nameof(IPO), typeof(Sections.IPO) },
      };
   }
}
