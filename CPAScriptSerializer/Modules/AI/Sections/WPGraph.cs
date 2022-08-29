﻿using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI.Sections {
   
   public class WPGraph : CPAScriptSection {

      public WPGraph(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>() { };
      public override Type CommandTypeFallback => null;
   }
}