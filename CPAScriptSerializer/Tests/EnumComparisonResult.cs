using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Tests {

   [Flags]
   public enum EnumComparisonResult {
      FilesMatch = 0,
      LineCountDoesntMatch = 1 << 0,
      LineContentDoesntMatch = 1 << 1,
   }
}
