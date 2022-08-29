﻿using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Modules.IPT;
using CPAScriptSerializer.Modules.IPT.Enums;

namespace CPAScriptSerializer.Commands
{
   public class Parameter
   {
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

      // Nullables (optional parameters):
      public static implicit operator byte?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : byte.Parse(p.Value);
      public static implicit operator sbyte?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : sbyte.Parse(p.Value);

      public static implicit operator int?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : int.Parse(p.Value);
      public static implicit operator uint?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : uint.Parse(p.Value);

      public static implicit operator long?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : long.Parse(p.Value);
      public static implicit operator ulong?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : ulong.Parse(p.Value);

      public static implicit operator short?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : short.Parse(p.Value);
      public static implicit operator ushort?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : ushort.Parse(p.Value);

      public static implicit operator float?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : float.Parse(p.Value);
      public static implicit operator double?(Parameter p) => string.IsNullOrWhiteSpace(p.Value) ? null : double.Parse(p.Value);

      // Enums:
      public static implicit operator EnumJoyPadAxe(Parameter p) => Enum.Parse<EnumJoyPadAxe>(p.Value);
      public static implicit operator EnumJoyPadButton(Parameter p) => Enum.Parse<EnumJoyPadButton>(p.Value);
      public static implicit operator EnumRefType(Parameter p) => Enum.Parse<EnumRefType>(p.Value);
   }
}