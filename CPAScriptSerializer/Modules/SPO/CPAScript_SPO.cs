using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.CPAScriptSerializer.Modules.SPO.Sections;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.SPO {
   public class CPAScript_SPO : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SuperObject), typeof(SuperObject) },
         { nameof(Matrix), typeof(Matrix) },
         { Edit_ListModifSuperObject.SectionName, typeof(Edit_ListModifSuperObject) },
      };
   }
}
