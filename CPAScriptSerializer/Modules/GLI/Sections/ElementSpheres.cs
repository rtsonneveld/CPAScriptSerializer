using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles;
using CPAScriptSerializer.Modules.GLI.Commands.ElementSpheres;

namespace CPAScriptSerializer.Modules.GLI.Sections {

   // GLI_xLoadElementIndexedTriangles
   public class ElementSpheres : ElementSection
   {
      [CommandParameter(0)] public int NumberOfSpheres;

      public ElementSpheres(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddSphere), typeof(AddSphere)},
      };

      
   }
}
