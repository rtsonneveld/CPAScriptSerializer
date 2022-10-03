﻿using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Commands.CHL;

namespace CPAScriptSerializer.Modules.GAM.Sections.CHL {
   public class A3dChannelNames : CPAScriptSection {

      [CommandParameter(0)] public int NumberOfChannels;

      public A3dChannelNames(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddChannelName), typeof(AddChannelName) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}
