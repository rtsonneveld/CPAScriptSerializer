using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GLI.Commands;
using CPAScriptSerializer.Modules.GMT.Commands;

namespace CPAScriptSerializer.Modules.GMT.Sections {
   public class GameMaterial : CPAScriptSection
   {

      public GameMaterial(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(VisualMat), typeof(VisualMat) },
      };

      public override Type CommandTypeFallback(string name)
      {
         throw new NotImplementedException();
      }
   }
}
