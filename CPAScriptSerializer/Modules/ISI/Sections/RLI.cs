using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.ISI.Commands;

namespace CPAScriptSerializer.Modules.ISI.Sections {

   /// <summary>
   /// Received Light Intensity
   /// </summary>
   public class RLI : CPAScriptSection {

      // [CommandParameter(0)] NBRLI
      [CommandParameter(1)] public int NumberOfRLI;

      public RLI(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(IS2), typeof(IS2) },
      };
   }
}
