using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Commands.WAY;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   // Only used as subsection
   public class Waypoint : CPAScriptSection
   {
      public Waypoint(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Vertex), typeof(Vertex) },
         { nameof(Radius), typeof(Radius) },
      };

      
   }
}