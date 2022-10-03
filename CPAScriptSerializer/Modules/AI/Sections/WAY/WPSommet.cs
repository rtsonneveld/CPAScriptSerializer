using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.AI.Commands.WAY;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   public class WPSommet : CPAScriptSection
   {
      public WPSommet(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };
      public override Type CommandTypeFallback(string name) => typeof(WpSommetWaypoint);
   }
}