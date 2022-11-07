using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OAC.Sections.ENL;

namespace CPAScriptSerializer.Modules.Editor.OAC
{
   public class CPAScript_ENL : CPAScript
   {
      public override Dictionary<string, Type> SectionTypes { get; } = new Dictionary<string, Type>()
      {
         {nameof(CreateNamesList), typeof(CreateNamesList)},
         {nameof(AddToNamesList), typeof(AddToNamesList)},
         {nameof(NamesList), typeof(NamesList)},
         {nameof(AddENL), typeof(AddENL)},
      };
   }
}
