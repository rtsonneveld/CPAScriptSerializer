using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.AI.Sections.DEC;

namespace CPAScriptSerializer.Modules.GAM.Sections.CAR.Character_.Brain_ {
   public class InitVariables : CreateVariables // Reuse the .dec file's CreateVariables section
   {
      public InitVariables(string sectionId, string sectionType) : base(sectionId, sectionType) { }
   }
}
