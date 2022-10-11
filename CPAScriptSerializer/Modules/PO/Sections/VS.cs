using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.PO.Sections {
   public class VS : CPAScriptSection
   {
      // TODO: Validate LOD Count
      [CommandParameter(0)] public int LODCount;

      public VS(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(LOD), typeof(LOD)},
      };
   }
}
