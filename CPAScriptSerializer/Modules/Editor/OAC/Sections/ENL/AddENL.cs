using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OAC.Commands.ENL;
using Type = System.Type;

namespace CPAScriptSerializer.Modules.Editor.OAC.Sections.ENL
{
   public class AddENL : CPAScriptSection
   {
      public AddENL(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(ZA), typeof(ZA) },
         { nameof(DefaultZA), typeof(DefaultZA) },
         { nameof(ObjectsList), typeof(ObjectsList) },
         { nameof(ZAList), typeof(ZAList) },
      };
   }
}