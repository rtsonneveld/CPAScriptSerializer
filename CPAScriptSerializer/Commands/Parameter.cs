using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands {
   public class Parameter {
      
      public string Value;

      public Parameter(string value)
      {
         Value = value;
      }

      public static implicit operator Parameter(string s) => new(s);

      public static implicit operator string(Parameter p) => p.Value;

      public static implicit operator byte(Parameter p) => byte.Parse(p.Value);
      public static implicit operator sbyte(Parameter p) => sbyte.Parse(p.Value);

      public static implicit operator int(Parameter p) => int.Parse(p.Value);
      public static implicit operator uint(Parameter p) => uint.Parse(p.Value);

      public static implicit operator short(Parameter p) => short.Parse(p.Value);
      public static implicit operator ushort(Parameter p) => ushort.Parse(p.Value);

      public static implicit operator long(Parameter p) => long.Parse(p.Value);
      public static implicit operator ulong(Parameter p) => ulong.Parse(p.Value);

      public static implicit operator float(Parameter p) => float.Parse(p.Value);
      public static implicit operator double(Parameter p) => double.Parse(p.Value);
   }
}
