using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.Editor.TGM.Commands;

namespace CPAScriptSerializer.Modules.Editor.TGM.Sections {
   public class CollideMaterial : CPAScriptSection {
      public CollideMaterial(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(Collision), typeof(Collision) },
      };
   }
}
