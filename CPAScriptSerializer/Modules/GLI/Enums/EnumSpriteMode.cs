using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GLI.Enums {

   [ReplaceUnderscoresEnum("")] // Ignore underscores
   public enum EnumSpriteMode {
      _2DScaled,
      _2DNonScaled,
      _SemiLookAt,
      _LensFlare,
   }
}
