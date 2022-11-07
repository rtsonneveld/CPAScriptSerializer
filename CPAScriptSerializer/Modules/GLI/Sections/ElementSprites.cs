using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles;
using CPAScriptSerializer.Modules.GLI.Commands.ElementSpheres;
using CPAScriptSerializer.Modules.GLI.Commands.ElementSprites;

namespace CPAScriptSerializer.Modules.GLI.Sections {

   // GLI_xLoadElementIndexedTriangles
   public class ElementSprites : ElementSection
   {
      [CommandParameter(0)] public int NumberOfSprites;

      public ElementSprites(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddSprite), typeof(AddSprite)},
      };

      
   }
}
