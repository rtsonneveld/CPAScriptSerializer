using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer {
   /// <summary>
   /// Use this attribute whenever an enum should be serialized as the enum value instead of the name
   /// </summary>
   public class SerializeEnumAsValueAttribute : Attribute { }
}
