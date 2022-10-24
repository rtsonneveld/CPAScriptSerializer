using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer {
   /// <summary>
   /// Use this attribute whenever an enum should be serialized with underscores replaced by spaces, and deserialized/parsed with spaces replaced by underscores
   /// </summary>
   public class UseUnderscoresAsSpacesEnumAttribute : Attribute { }
}
