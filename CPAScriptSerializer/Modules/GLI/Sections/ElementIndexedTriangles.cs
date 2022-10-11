using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles;

namespace CPAScriptSerializer.Modules.GLI.Sections {

   // GLI_xLoadElementIndexedTriangles
   public class ElementIndexedTriangles : ElementSection
   {
      [CommandParameter(0)] public int NumberOfFaces;
      [CommandParameter(1)] public int NumberOfElementUVs;

      public ElementIndexedTriangles(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(Material), typeof(Material)},
         {nameof(AddFaceUV), typeof(AddFaceUV)},
         {nameof(AddUV), typeof(AddUV)},
      };

      
   }
}
