using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OZO.Sections;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.Editor.OZO {

   /// <summary>
   /// Bounding Volumes
   /// </summary>
   public class CPAScript_BDV : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SetBoundingVolume), typeof(SetBoundingVolume) },
         { nameof(Geometric), typeof(Geometric) },
         { nameof(ElementIndexedTriangles), typeof(ElementIndexedTriangles) },
         { nameof(ElementSpheres), typeof(ElementSpheres) },
         { nameof(ElementAlignedBoxes), typeof(ElementAlignedBoxes) },
      };
   }
}
