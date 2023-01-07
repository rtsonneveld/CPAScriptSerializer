using System;
using System.Collections.Generic;

namespace CPAScriptSerializer.Modules.AI.Sections.WAY
{
   // TODO: find an example of this section filled with data - haven't found it yet in either .way or .wp - RTS
   public class InWay : CPAScriptSection
   {
      public InWay(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>() { };
      
   }
}