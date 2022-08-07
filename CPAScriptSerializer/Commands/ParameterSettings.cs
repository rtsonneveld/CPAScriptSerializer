using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands {
   public class ParameterSettings : Attribute
   {
      public int Index { get; set; }

      public ParameterSettings(int index)
      {
         Index = index;
      }
   }
}
