﻿using System;
using System.Collections.Generic;
using System.Linq;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Commands.Generic;
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

      public Geometric(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LookAt), typeof(LookAt) },
         { nameof(AddVertex), typeof(AddVertex) },
         { nameof(AddElement), typeof(AddElement) },
         { "Comment", typeof(EmptyCommand) }, // Ignore these comments
      };

      

      public override void ValidateParameters()
      {
         base.ValidateParameters();

         // TODO: add checks
         //if (NbPoints != Items.Where(item is Point))
      }
   }
}
