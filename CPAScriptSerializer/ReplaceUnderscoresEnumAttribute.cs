using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer {
   /// <summary>
   /// Use this attribute whenever an enum should be serialized with underscores replaced by another character, and deserialized/parsed with this character replaced by underscores
   /// NOTE: If an empty replacement string is used, exactly ONE underscore should always be placed at the start of the enum!
   /// </summary>
   public class ReplaceUnderscoresEnumAttribute : Attribute
   {
      public string ReplacementString;

      public ReplaceUnderscoresEnumAttribute() : this(" ") { }

      public ReplaceUnderscoresEnumAttribute(string replacementString)
      {
         ReplacementString = replacementString;
      }
   }
}
