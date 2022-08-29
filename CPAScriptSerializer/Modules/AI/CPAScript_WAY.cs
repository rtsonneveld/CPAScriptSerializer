using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI {
   
   // The .wp extension is also used for some reason
   public class CPAScript_WAY : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new()
      {
         { nameof(Sections.Isolate), typeof(Sections.Isolate) },
         { nameof(Sections.InWay), typeof(Sections.InWay) },
         { nameof(Sections.WPGraph), typeof(Sections.WPGraph) },
         { nameof(Sections.WPSommet), typeof(Sections.WPSommet) },
         { nameof(Sections.Waypoint), typeof(Sections.Waypoint) },
      };
   }
}
