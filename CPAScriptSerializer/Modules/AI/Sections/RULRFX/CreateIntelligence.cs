using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.AI.Sections.RULRFX.CreateIntelligence_;

namespace CPAScriptSerializer.Modules.AI.Sections.RULRFX {
   public class CreateIntelligence : CPAScriptSection
   {
      private const int DEFAULT_ACTION_TABLE_NB_ENTRIES = 3;

      [CommandParameter(0)] public int NumberOfComports; // Todo: add validation
      [CommandParameter(1)] public int ActionTableNbEntries = DEFAULT_ACTION_TABLE_NB_ENTRIES; // This is 3 by default
      [CommandParameter(2)] public string DefaultComport;

      public CreateIntelligence(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(CreateComport), typeof(CreateComport) }
      };

      
   }
}
