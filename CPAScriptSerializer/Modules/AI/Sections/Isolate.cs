using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI.Sections
{
   public class Isolate : CPAScriptSection
   {
      public Isolate(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Waypoint), typeof(Waypoint) },
      };

      public override Type CommandTypeFallback(string name) => null;
   }
}