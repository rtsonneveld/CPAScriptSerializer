using System;
using System.Collections.Generic;
using CPAScriptSerializer.Modules.GLI.Commands.Texture;
using CPAScriptSerializer.Modules.GLI.Sections;
using CPAScriptSerializer.Modules.GMT.Sections;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.GLI {

   public class CPAScript_MOD : CPAScript {

      /*
       * #define GLI_C_SectionTexture "Texture"
         #define GLI_C_SectionVisualMaterial "Material"
         #define GLI_C_SectionGeometric "Geometric"
         #define GLI_C_SectionPhysical "Physical"
         #define GLI_C_SectionSpecialEffect "SpecialEffect"
         #define GLI_C_SectionElementIndexedTriangles "ElementIndexedTriangles"
         #define GLI_C_SectionElementFaceMapDescriptors "ElementFaceMapDescriptors"
         #define GLI_C_SectionElementSprites "ElementSprites"
         #define GLI_C_SectionElementTMeshes "ElementTMeshes"
         #define GLI_C_SectionElementLines "ElementLines"
         #define GLI_C_SectionElementSpheres "ElementSpheres"
         #define GLI_C_SectionElementAlignedBoxes "ElementAlignedBoxes"
         #define GLI_C_SectionElementPoints "ElementPoints"
         #define GLI_C_SectionElementCones "ElementCones"
       */

      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { EditListModifGeometric.Name, typeof(EditListModifGeometric) },
         { nameof(Geometric), typeof(Geometric) },
         { nameof(Matrix), typeof(Matrix) },
         { nameof(ElementIndexedTriangles), typeof(ElementIndexedTriangles) },
         { nameof(ElementSpheres), typeof(ElementSpheres) },
         { nameof(ElementAlignedBoxes), typeof(ElementAlignedBoxes) },
         { nameof(ElementSprites), typeof(ElementSprites) },
         { nameof(Sprite), typeof(Sprite) },
         // WP.mod only?
         { nameof(GameMaterial), typeof(GameMaterial) },
         { nameof(Material), typeof(Material) },
         { nameof(Texture), typeof(Texture) },
      };
   }
}
