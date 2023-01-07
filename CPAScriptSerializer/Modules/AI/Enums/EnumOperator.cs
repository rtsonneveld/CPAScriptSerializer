using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CPAScriptSerializer.Modules.AI.Enums {
   public enum EnumOperator {
      Operator_Plus,
      Operator_Minus,
      Operator_Mul,
      Operator_Div,
      Operator_UnaryMinus,
      Operator_PlusAffect,
      Operator_MinusAffect,
      Operator_MulAffect,
      Operator_DivAffect,
      Operator_PlusPlusAffect,
      Operator_MinusMinusAffect,
      Operator_Affect,
      Operator_Dot,
      Operator_GetVectorX, // .X
      Operator_GetVectorY, // .Y
      Operator_GetVectorZ, // .Z
      Operator_VectorPlusVector,
      Operator_VectorMinusVector,
      Operator_VectorMulScalar,
      Operator_VectorDivScalar,
      Operator_VectorUnaryMinus,
      [Description("")]
      Operator_SetVectorX, // .X:=
      Operator_SetVectorY, // .Y:=
      Operator_SetVectorZ, // .Z:=
      Operator_Ultra,
      Operator_ModelCast,
      Operator_Array,
      Operator_AffectArray
   }

   public static class EnumOperatorUtils
   {
      public static EnumOperator Parse(string value)
      {
         switch (value) {
            case ".X": return EnumOperator.Operator_GetVectorX;
            case ".Y": return EnumOperator.Operator_GetVectorY;
            case ".Z": return EnumOperator.Operator_GetVectorZ;

            case ".X:=": return EnumOperator.Operator_SetVectorX;
            case ".Y:=": return EnumOperator.Operator_SetVectorY;
            case ".Z:=": return EnumOperator.Operator_SetVectorZ;

            default: return Enum.Parse<EnumOperator>(value, true);
         }
      }

      public static string ExportString(this EnumOperator op)
      {

         switch (op) {
            case EnumOperator.Operator_GetVectorX: return ".X";
            case EnumOperator.Operator_GetVectorY: return ".Y";
            case EnumOperator.Operator_GetVectorZ: return ".Z";

            case EnumOperator.Operator_SetVectorX: return ".X:=";
            case EnumOperator.Operator_SetVectorY: return ".Y:=";
            case EnumOperator.Operator_SetVectorZ: return ".Z:=";

            default: return op.ToString();
         }
      }
   }
}
