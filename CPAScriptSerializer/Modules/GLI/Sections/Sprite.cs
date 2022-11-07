using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GLI.Commands.ElementIndexedTriangles;
using CPAScriptSerializer.Modules.GLI.Commands.ElementSpheres;
using CPAScriptSerializer.Modules.GLI.Commands.Sprite;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   
   public class Sprite : CPAScriptSection
   {
      [CommandParameter(0)] public int NumberOfSprites;

      public Sprite(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(AddMaterial), typeof(AddMaterial)},
         {nameof(AddInfo), typeof(AddInfo)},
      };

      
   }
}
