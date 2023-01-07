using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GLI.Commands.ElementAlignedBoxes;
using CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles;
using CPAScriptSerializer.Modules.GLI.Commands.ElementSpheres;

namespace CPAScriptSerializer.Modules.GLI.Sections {

   // GLI_xLoadElementIndexedTriangles
   public class ElementAlignedBoxes : ElementSection
   {
      [CommandParameter(0)] public int NumberOfSpheres;

      public ElementAlignedBoxes(string sectionId, string sectionType) : base(sectionId, sectionType) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddAlignedBox), typeof(AddAlignedBox)},
      };

      
   }
}
