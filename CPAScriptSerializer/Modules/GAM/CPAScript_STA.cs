using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections;
using CPAScriptSerializer.Modules.GAM.Sections.STA;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_STA : CPAScript
   {

      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      { 
         {nameof(CreateNewState), typeof(CreateNewState)},
      };


   }
}
