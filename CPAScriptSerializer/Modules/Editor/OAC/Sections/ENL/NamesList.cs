using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.OAC.Commands.ENL;
using Type = System.Type;

namespace CPAScriptSerializer.Modules.Editor.OAC.Sections.ENL
{
   public class NamesList : CPAScriptSection
    {
        public NamesList(string sectionId, string sectionType) : base(sectionId, sectionType)
        {
        }

        public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(AddName), typeof(AddName) },
      };
    }
}
