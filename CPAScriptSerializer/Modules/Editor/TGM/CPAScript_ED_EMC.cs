using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TGM.Sections;

namespace CPAScriptSerializer.Modules.Editor.TGM {

   /// <summary>
   /// Ed.emc is the only file with the .emc extension that's not an editor macro file but instead is the editor material config....
   /// </summary>
   public class CPAScript_ED_EMC : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Zone.ZDE), typeof(Zone.ZDE) },
         { nameof(Zone.ZDD), typeof(Zone.ZDD) },
         { nameof(Zone.ZDM), typeof(Zone.ZDM) },
         { nameof(Zone.ZDR), typeof(Zone.ZDR) },
      };
   }
}
