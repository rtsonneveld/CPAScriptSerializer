using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer {
   public class CPAScriptReference<T> where T:CPAScriptItem
   {
      public string Value;

      // TODO: parse references and allow them to be constructed/manipulated
      public CPAScriptReference(string s)
      {
         Value = s;
      }

      public override string ToString()
      {
         return Value;
      }
   }
}
