﻿using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   public class Isolate : CPAScriptSection
   {
      public Isolate(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Waypoint), typeof(Waypoint) },
      };

      
   }
}