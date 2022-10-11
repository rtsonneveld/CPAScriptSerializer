using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Enums {
   public enum EnumInitFlags {
      WhenPlayerGoOutOfActionZone = 0,
      Always,
      WhenPlayerIsDead,
      WhenMapJustLoaded,
      WhenSavedGameJustLoaded,
      NeverBackWhenTaken,
      NumberOfObjectInit,
      WhenGeneratorIsDesactivated,
      WhenGoOutOfZone
   }
}
