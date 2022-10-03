using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Sections.WAY;

namespace CPAScriptSerializer.Modules.AI
{
   // The .wp extension is also used for some reason
   public class CPAScript_WAY : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(Isolate), typeof(Isolate) },
         { nameof(InWay), typeof(InWay) },
         { nameof(WPGraph), typeof(WPGraph) },
         { nameof(WPSommet), typeof(WPSommet) },
         { nameof(Waypoint), typeof(Waypoint) },
      };
   }
}