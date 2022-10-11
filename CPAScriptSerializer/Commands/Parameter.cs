using System;
using System.Linq;
using System.Reflection;
using CPAScriptSerializer.Modules.AI.Enums;
using CPAScriptSerializer.Modules.GAM.Enums;
using CPAScriptSerializer.Modules.GLI.Enums;
using CPAScriptSerializer.Modules.IPT.Enums;
using CPAScriptSerializer.Modules.SND.Enums;

namespace CPAScriptSerializer.Commands
{
   public partial class Parameter
   {
      public string Value;

      public Parameter(string value)
      {
         // Trim quotes from start and end
         if (value.StartsWith('"') && value.EndsWith('"')) {
            value = value[1..^1];
         }

         Value = value;
      }

      public static void FillParameters(CPAScriptItem item, Parameter[] parameters)
      {
         var instanceFields = item.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);

         foreach (var field in instanceFields) {
            var fieldSettings = field.GetCustomAttribute<CommandParameterAttribute>();
            if (fieldSettings != null) {
               if (fieldSettings.Index < parameters.Length) {

                  object? fieldValue = null;

                  if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(CPAScriptReference<>)) {

                     Type myParameterizedSomeClass = typeof(CPAScriptReference<>).MakeGenericType(field.FieldType.GetGenericArguments()[0]);
                     ConstructorInfo constr = myParameterizedSomeClass.GetConstructor(new Type[] { typeof(string) });
                     fieldValue = constr?.Invoke(new object[] { parameters[fieldSettings.Index].Value });

                  } else {

                     // We need to find the implicit operator for the Parameter object
                     MethodInfo converter = typeof(Parameter).GetMethods().FirstOrDefault(m =>
                        m.Name == "op_Implicit" && m.ReturnParameter?.ParameterType == field.FieldType);

                     if (converter != null) {
                        fieldValue = converter.Invoke(null, new object[] {parameters[fieldSettings.Index]});
                     } else {
                        throw new Exception($"No implicit conversion found for field type {field.FieldType}");
                     }
                  }

                  field.SetValue(item, fieldValue);
               }
            }
         }
      }

      public static implicit operator Parameter(string s) => new(s);

      public static implicit operator string(Parameter p) => p.Value;

      public static implicit operator bool(Parameter p) => bool.Parse(p.Value);

      public static implicit operator byte(Parameter p) => byte.Parse(p.Value);
      public static implicit operator sbyte(Parameter p) => sbyte.Parse(p.Value);

      public static implicit operator int(Parameter p) => int.Parse(p.Value);
      public static implicit operator uint(Parameter p)
      {
         if (p.Value == "CapaNull") // TODO: Maybe make this less hardcoded
         {
            return 0;
         }
         return uint.Parse(p.Value);
      }

      public static implicit operator short(Parameter p) => short.Parse(p.Value);
      public static implicit operator ushort(Parameter p) => ushort.Parse(p.Value);

      public static implicit operator long(Parameter p) => long.Parse(p.Value);
      public static implicit operator ulong(Parameter p) => ulong.Parse(p.Value);

      public static implicit operator float(Parameter p) => float.Parse(p.Value);
      public static implicit operator double(Parameter p) => double.Parse(p.Value);


      // Nullables (optional parameters):

      public static implicit operator bool?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : bool.Parse(p.Value);

      public static implicit operator byte?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : byte.Parse(p.Value);

      public static implicit operator sbyte?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : sbyte.Parse(p.Value);

      public static implicit operator int?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : int.Parse(p.Value);

      public static implicit operator uint?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : uint.Parse(p.Value);

      public static implicit operator long?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : long.Parse(p.Value);

      public static implicit operator ulong?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : ulong.Parse(p.Value);

      public static implicit operator short?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : short.Parse(p.Value);

      public static implicit operator ushort?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : ushort.Parse(p.Value);

      public static implicit operator float?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : float.Parse(p.Value);

      public static implicit operator double?(Parameter p) =>
         string.IsNullOrWhiteSpace(p.Value) ? null : double.Parse(p.Value);

      #region Enums

      #region AI

      public static implicit operator EnumCondition(Parameter p) => Enum.Parse<EnumCondition>(p.Value, true);
      public static implicit operator EnumDsgVarSaveType(Parameter p) => Enum.Parse<EnumDsgVarSaveType>(p.Value, true);
      public static implicit operator EnumDsgVarInitType(Parameter p) => Enum.Parse<EnumDsgVarInitType>(p.Value, true);
      public static implicit operator EnumField(Parameter p) => Enum.Parse<EnumField>(p.Value, true);
      public static implicit operator EnumFunction(Parameter p) => Enum.Parse<EnumFunction>(p.Value, true);
      public static implicit operator EnumKeyWord(Parameter p) => Enum.Parse<EnumKeyWord>(p.Value, true);
      public static implicit operator EnumMetaAction(Parameter p) => Enum.Parse<EnumMetaAction>(p.Value, true);
      public static implicit operator EnumOperator(Parameter p) => EnumOperatorUtils.Parse(p.Value);
      public static implicit operator EnumProcedure(Parameter p) => Enum.Parse<EnumProcedure>(p.Value, true);

      #endregion

      #region IPT

      public static implicit operator EnumJoyPadAxe(Parameter p) => Enum.Parse<EnumJoyPadAxe>(p.Value, true);
      public static implicit operator EnumJoyPadButton(Parameter p) => Enum.Parse<EnumJoyPadButton>(p.Value, true);
      public static implicit operator EnumRefType(Parameter p) => Enum.Parse<EnumRefType>(p.Value, true);

      #endregion

      #region SND

      public static implicit operator EnumStorageType(Parameter p) => Enum.Parse<EnumStorageType>(p.Value, true);
      public static implicit operator EnumResourceType(Parameter p) => Enum.Parse<EnumResourceType>(p.Value, true);
      public static implicit operator EnumZipFormat(Parameter p) => Enum.Parse<EnumZipFormat>(p.Value, true);
      public static implicit operator EnumEventType(Parameter p) => Enum.Parse<EnumEventType>(p.Value, true);

      #endregion

      #region GAM
      public static implicit operator EnumTransitionStatusFlag(Parameter p) => Enum.Parse<EnumTransitionStatusFlag>(p.Value, true);
      public static implicit operator EnumInitFlags(Parameter p) => Enum.Parse<EnumInitFlags>(p.Value, true);
      public static implicit operator EnumDynamSize(Parameter p) => Enum.Parse<EnumDynamSize>(p.Value, true);
      public static implicit operator EnumGenericEventType(Parameter p) => Enum.Parse<EnumGenericEventType>(p.Value, true);
      public static implicit operator EnumObjectType(Parameter p) => Enum.Parse<EnumObjectType>(p.Value, true);
      #endregion

      #region GLI

      public static implicit operator EnumElementType(Parameter p) => Enum.Parse<EnumElementType>(p.Value, true);
      public static implicit operator EnumMaterialType(Parameter p) => Enum.Parse<EnumMaterialType>(p.Value, true);
      public static implicit operator EnumChromaKeyEnabled(Parameter p) => Enum.Parse<EnumChromaKeyEnabled>(p.Value, true);
      public static implicit operator EnumChromaKeyFilter(Parameter p) => Enum.Parse<EnumChromaKeyFilter>(p.Value, true);
      public static implicit operator EnumPriority(Parameter p) => Enum.Parse<EnumPriority>(p.Value, true);
      public static implicit operator EnumQuality(Parameter p) => Enum.Parse<EnumQuality>(p.Value, true);
      public static implicit operator CPAScriptSerializer.Modules.GMT.Enums.EnumOnOffToggle(Parameter p) => Enum.Parse<CPAScriptSerializer.Modules.GMT.Enums.EnumOnOffToggle>(p.Value, true);

      #endregion

      #region GMT

      public static implicit operator CPAScriptSerializer.Modules.GLI.Enums.EnumOnOffToggle(Parameter p) => Enum.Parse<CPAScriptSerializer.Modules.GLI.Enums.EnumOnOffToggle>(p.Value, true);

      #endregion

      #region TGM

      public static implicit operator CPAScriptSerializer.Modules.Editor.TGM.Enums.EnumZoneType(Parameter p) => Enum.Parse<CPAScriptSerializer.Modules.Editor.TGM.Enums.EnumZoneType>(p.Value, true);

      #endregion


      #region TIA

      public static implicit operator CPAScriptSerializer.Modules.Editor.TIA.Enums.EnumLanguage(Parameter p) => Enum.Parse<CPAScriptSerializer.Modules.Editor.TIA.Enums.EnumLanguage>(p.Value, true);

      #endregion

      #endregion

      public static string ExportValue(object? value, CommandParameterAttribute fieldSettings)
      {
         if (value == null) {
            throw new Exception("Value was null");
         }

         string valueString = value.ToString();

         if (valueString == null) {
            throw new Exception("valueString was null");
         }

         if (value.GetType().IsGenericType && value.GetType().GetGenericTypeDefinition() == typeof(CPAScriptReference<>)) {
            return '"' + valueString + '"';
         }

         return value switch
         {
            bool => valueString.ToUpper(),
            float or double => $"\"{value:F6}\"",
            string => '"' + valueString + '"',
            _ => valueString
         };

      }
   }
}