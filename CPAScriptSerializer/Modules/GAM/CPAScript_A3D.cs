using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GAM.Sections.A3D;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_A3D : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(A3dHEADER), typeof(A3dHEADER) },
         { nameof(A3dStringsTable), typeof(A3dStringsTable) },
         { nameof(A3dAnimationGENERAL), typeof(A3dAnimationGENERAL) },
         { nameof(A3dCompressionsTable), typeof(A3dCompressionsTable) },
         { nameof(A3dQuaternionsTable), typeof(A3dQuaternionsTable) },
         { nameof(A3dVertexesTable), typeof(A3dVertexesTable) },

         // Unused
         { nameof(CutPointsList), typeof(CutPointsList) },

         { nameof(DeformationList), typeof(DeformationList) },

         #region DeformationList Subsections
            {nameof(DeformationFrame), typeof(DeformationFrame)},
         #endregion

         { nameof(HierarchiesList), typeof(HierarchiesList) },

         #region HierarchiesList Subsections
            { nameof(A3dHIERARCHY), typeof(A3dHIERARCHY)},
         #endregion
         
         { nameof(Channel), typeof(Channel) },

         #region Channel Subsections
            { nameof(Frame), typeof(Frame)},
            { nameof(Key), typeof(Key)},
         #endregion

         { nameof(SpeedsList), typeof(SpeedsList) },

         #region Channel Subsections
         { nameof(Speed), typeof(Speed)},
         #endregion
      };
   }
}
