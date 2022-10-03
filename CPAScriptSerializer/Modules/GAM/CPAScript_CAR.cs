using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Sections;
using CPAScriptSerializer.Modules.GAM.Sections.CAR;
using CPAScriptSerializer.Modules.GAM.Sections.STA;

namespace CPAScriptSerializer.Modules.GAM {
   public class CPAScript_CAR : CPAScript
   {

      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      { 
         {nameof(Character), typeof(Character)},
      };


   }
}
