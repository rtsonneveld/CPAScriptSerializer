using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.TAC.Sections {
   public class CreateNewArrayOfZoneSet : CPAScriptSection
   {

      [CommandParameter(0, ignoreValues: new object[]{0})] public int NumberOfCollset;

      public CreateNewArrayOfZoneSet(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddActivation), typeof(AddActivation) },
      };
      
   }
}
