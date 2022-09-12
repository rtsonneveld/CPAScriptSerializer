using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.SPO.Sections;

namespace CPAScriptSerializer.Modules.SPO {
   public class CPAScript_SPO : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(SuperObject), typeof(SuperObject) },
         { nameof(Matrix), typeof(Matrix) },
         { EditListModifSuperObject.Name, typeof(EditListModifSuperObject) },
      };
   }
}
