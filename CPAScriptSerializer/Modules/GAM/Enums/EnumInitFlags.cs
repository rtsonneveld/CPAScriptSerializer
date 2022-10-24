using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Enums {
   public enum EnumInitFlags {
      WhenPlayerGoOutOfActionZone = 0,
      NeverBack,
      Always,
      WhenGoOutOfZone,
      WhenPlayerDead,
      WhenMapLoaded,
      WhenSavedGameLoaded,
   }
}
