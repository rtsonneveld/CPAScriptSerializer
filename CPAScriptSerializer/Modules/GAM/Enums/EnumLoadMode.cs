using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Enums {
   [SerializeEnumAsValue]
   public enum EnumLoadMode {
      SNA_LOAD_SCRIPT = 0,
      SNA_LOAD_SNAPSHOT = 1,
      SNA_SAVE_SNAPSHOT = 2
   }
}
