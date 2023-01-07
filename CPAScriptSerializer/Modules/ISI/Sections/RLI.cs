using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.ISI.Commands;

namespace CPAScriptSerializer.Modules.ISI.Sections {

   /// <summary>
   /// Received Light Intensity
   /// </summary>
   public class RLI : CPAScriptSection
   {

      [UnusedByCPA] [CommandParameter(0)] public string NBRLI = "nbrli";
      [CommandParameter(1)] public int NumberOfRLI;

      public RLI(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(IS2), typeof(IS2) },
      };
   }
}
