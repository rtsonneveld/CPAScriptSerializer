using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.Editor.TAC.Sections {
   public class ArrayOfZoneSet : CPAScriptSection {
      public ArrayOfZoneSet(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateNewArrayOfZoneSet), typeof(CreateNewArrayOfZoneSet) },
      };

      
   }
}
