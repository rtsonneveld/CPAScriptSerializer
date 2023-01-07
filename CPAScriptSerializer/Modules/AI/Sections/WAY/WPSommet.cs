using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Commands.WAY;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   public class WPSommet : CPAScriptSection
   {
      // TODO: it seems the editor expects two arguments here, not one, weight and capabilities? check wpwaypt.c line 788
      [CommandParameter(0)] public string Capabilities;
      /// TODO: Create a special type for this (capabilities/bits)

      public WPSommet(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };
      public override Type CommandTypeFallback(string name) => typeof(WpSommetWaypoint);
   }
}