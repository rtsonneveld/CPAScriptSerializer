using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.GAM.Enums {

   [SerializeEnumAsValue]
   public enum EnumKeyAttribute {
      /* TODO: this should technically be : short but at the moment int is hardcoded in Parameter.cs:
         
         if (value.GetType().GetCustomAttributes<SerializeEnumAsValueAttribute>().Any()) {
            return ((int)value).ToString();
         }
       */
      None = 0,
      Simple = 1,
      Double = 2,
   }
}
