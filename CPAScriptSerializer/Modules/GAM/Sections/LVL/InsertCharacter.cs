using System;
using System.Collections.Generic;
using CPAScriptSerializer.Commands.Generic;
using CPAScriptSerializer.Modules.GAM.Commands.LVL;
using CPAScriptSerializer.Modules.SPO.Commands.Matrix;
using InitialState = CPAScriptSerializer.Modules.GAM.Commands.LVL.InitialState;

namespace CPAScriptSerializer.Modules.GAM.Sections.LVL {
   public class InsertCharacter : CPAScriptSection
   {

      private const string CharacterIsInAllSubmaps = "CharacterIsInAllSubmaps";

      public InsertCharacter(string sectionId) : base(sectionId) { }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LinkCharacter), typeof(LinkCharacter) },
         { nameof(MatrixTranslation), typeof(MatrixTranslation) },
         { nameof(MatrixRotation), typeof(MatrixRotation) },
         { nameof(MatrixScale), typeof(MatrixScale) },
         { nameof(CharacterFlags), typeof(CharacterFlags) },
         { nameof(CharacterIsAlwaysActive), typeof(CharacterIsAlwaysActive) },
         { nameof(Transparency), typeof(Transparency) },
         { nameof(InitialState), typeof(InitialState) },
         { CharacterIsInAllSubmaps, typeof(EmptyCommand) },
      };

      
   }
}
