using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.ISI.Commands;

namespace CPAScriptSerializer.Modules.ISI.Sections {

   /// <summary>
   /// ISI (Instance Specific Info) of an IPO (Instantiated Physical Object)
   /// </summary>
   public class ISI : CPAScriptSection {

      // [CommandParameter(0)] NBRLOD
      [CommandParameter(1)] public int NumberOfLOD;

      public ISI(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddLODRLI), typeof(AddLODRLI) },
         { nameof(AddVertexRLILOD), typeof(AddVertexRLILOD) },
      };
   }
}
