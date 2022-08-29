using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Commands;

namespace CPAScriptSerializer.Modules.AI.Sections {

   // Only used as subsection
   public class Waypoint : CPAScriptSection {

      public Waypoint(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes => new Dictionary<string, Type>()
      {
         {nameof(Vertex), typeof(Vertex)},
         {nameof(Radius), typeof(Radius)},
      };

      public override Type CommandTypeFallback => null;
   }
}
