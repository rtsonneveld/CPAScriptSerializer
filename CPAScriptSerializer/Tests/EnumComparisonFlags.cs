using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Tests {
   [Flags]
   public enum EnumComparisonFlags {
      IgnoreCase         = 1 << 0,
      IgnoreSingleQuotes = 1 << 1,
      IgnoreDoubleQuotes = 1 << 2,
      IgnoreEmptyLines   = 1 << 3,
      IgnoreTabs         = 1 << 4,
      IgnoreSpaces       = 1 << 5,
      RoundNumbers      = 1 << 6,
      IgnoreEmptyBracketPairs = 1 << 7,
      IgnoreColonAtEnd = 1 << 8,
   }
}
