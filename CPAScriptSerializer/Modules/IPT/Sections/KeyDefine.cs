﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPT.Commands;

namespace CPAScriptSerializer.Modules.IPT.Sections {
   
   public class KeyDefine : CPAScriptSection {
      public KeyDefine(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(NewKeyDefine), typeof(NewKeyDefine) }
      };

      public override Type CommandTypeFallback { get; }
   }
}
