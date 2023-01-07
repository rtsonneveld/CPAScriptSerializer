using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Tests {
   public class ComparisonResult
   {
      public EnumComparisonResult Flags;
      public Dictionary<int, (string original, string test)> DifferingLines = new Dictionary<int, (string original, string test)>();
   }
}
