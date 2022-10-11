using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GLI.Commands.Texture;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   public class Texture : CPAScriptSection {
      public Texture(string sectionId) : base(sectionId)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadTexture), typeof(LoadTexture) },
         { nameof(Tiling), typeof(Tiling) },
         { nameof(MipMapping), typeof(MipMapping) },
         { nameof(Chromakey), typeof(Chromakey) },
         { nameof(Quality), typeof(Quality) },
         { nameof(Priority), typeof(Priority) },
         { nameof(ZWrite), typeof(ZWrite) },
      };

      
   }
}
