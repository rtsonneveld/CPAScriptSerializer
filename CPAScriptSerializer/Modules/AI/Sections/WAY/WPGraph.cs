using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   public class WPGraph : CPAScriptSection
   {
      public WPGraph(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };
      
   }
}