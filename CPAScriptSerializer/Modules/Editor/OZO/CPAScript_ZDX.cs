using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OZO.Sections;
using CPAScriptSerializer.Modules.GLI.Sections;

namespace CPAScriptSerializer.Modules.Editor.OZO {

   /// <summary>
   /// Actor Zdx (zones)
   /// </summary>
   public class CPAScript_ZDX : CPAScript {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateNewArrayOfZdx), typeof(CreateNewArrayOfZdx)},
         {nameof(Geometric), typeof(Geometric)},
         {nameof(ElementIndexedTriangles), typeof(ElementIndexedTriangles)}, // Not sure if this is ever used but just in case
         {nameof(ElementSpheres), typeof(ElementSpheres)},
         {nameof(ElementAlignedBoxes), typeof(ElementAlignedBoxes)},
      };
   }
}
