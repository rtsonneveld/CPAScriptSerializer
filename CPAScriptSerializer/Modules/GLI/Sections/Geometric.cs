using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GLI.Commands.Geometric;

namespace CPAScriptSerializer.Modules.GLI.Sections {

   // Parameters: (xNbPoints, xNbEdges, xNbElements)

   public class Geometric : CPAScriptSection
   {
      [CommandParameter(0)]
      public int NbPoints;
      [CommandParameter(1)]
      public int NbEdge;
      [CommandParameter(2)]
      public int NbElements;

      public Geometric(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddVertex), typeof(AddVertex) },
         { nameof(AddElement), typeof(AddElement) },
      };

      

      public override void ValidateParameters()
      {
         base.ValidateParameters();

         // TODO: add checks
         //if (NbPoints != Items.Where(item is Point))
      }
   }
}
