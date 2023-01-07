using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.GLI.Commands.Texture;

namespace CPAScriptSerializer.Modules.GLI.Sections {
   public class Texture : CPAScriptSection {
      public Texture(string sectionId, string sectionType) : base(sectionId, sectionType)
      {
      }

      public override Dictionary<string, Type> CommandTypes { get; } = new Dictionary<string, Type>()
      {
         { nameof(LoadTexture), typeof(LoadTexture) },
         { nameof(Tiling), typeof(Tiling) },
         { nameof(MipMapping), typeof(MipMapping) },
         { "Mipmapping", typeof(MipMapping) }, // Case variation - I should make these case insensitive sometime maybe
         { nameof(Bilinear), typeof(Bilinear) },
         { nameof(Chromakey), typeof(Chromakey) },
         { nameof(Quality), typeof(Quality) },
         { nameof(Priority), typeof(Priority) },
         { nameof(ZWrite), typeof(ZWrite) },
      };

      
   }
}
