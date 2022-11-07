using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GLI.Enums {
   [Flags]
   [SerializeEnumAsValue]
   public enum EnumObjectLighted {
      Nothing = 0,
      LightMap = 1 << 0,
      LightPerso = 1 << 1,
      LightAll = LightMap|LightPerso,
   }
}
