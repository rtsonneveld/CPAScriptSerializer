using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   public class WPGraph : CPAScriptSection
   {
      /// <summary>
      /// Name of the waypoint section referencing this graph - not entirely sure what purpose this has. Doesn't seem to be used.
      /// </summary>
      [CommandParameter(0)] public CPAScriptReference<Waypoint> SectionReference;

      public WPGraph(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };
      
   }
}