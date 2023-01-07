using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Modules.AI.Commands.DEC {
   public readonly struct VariableValue<T>
   {
      public readonly string ConstantName = null;
      public readonly T Value;
      public bool IsConstant => !string.IsNullOrEmpty(ConstantName);

      public VariableValue(T value)
      {
         Value = value;
      }

      public VariableValue(string constantName)
      {
         ConstantName = constantName;
         Value = default;
      }

      public override string ToString()
      {
         if (IsConstant) {
            return ConstantName;
         }

         return Value.ToString();
      }
   }
}
