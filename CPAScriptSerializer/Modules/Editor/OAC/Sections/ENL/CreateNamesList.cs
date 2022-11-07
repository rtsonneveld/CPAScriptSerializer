using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;

namespace CPAScriptSerializer.Modules.Editor.OAC.Sections.ENL
{
   public class CreateNamesList : CPAScriptSection
   {
      [CommandParameter(0)] public EnumNameListType ListType;

      public CreateNamesList(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(NamesList), typeof(NamesList) },
         { nameof(AddENL), typeof(AddENL) },
      };
   }
}