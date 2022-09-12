using System;
using System.Linq;
using System.Reflection;
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
                        throw new Exception($"No implicit conversion found for field type {field.FieldType}!");
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
      public static implicit operator uint(Parameter p) => uint.Parse(p.Value);

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

      #region IPT

      public static implicit operator EnumJoyPadAxe(Parameter p) => Enum.Parse<EnumJoyPadAxe>(p.Value);
      public static implicit operator EnumJoyPadButton(Parameter p) => Enum.Parse<EnumJoyPadButton>(p.Value);
      public static implicit operator EnumRefType(Parameter p) => Enum.Parse<EnumRefType>(p.Value);

      #endregion

      #region SND

      public static implicit operator EnumStorageType(Parameter p) => Enum.Parse<EnumStorageType>(p.Value);
      public static implicit operator EnumResourceType(Parameter p) => Enum.Parse<EnumResourceType>(p.Value);
      public static implicit operator EnumZipFormat(Parameter p) => Enum.Parse<EnumZipFormat>(p.Value);
      public static implicit operator EnumEventType(Parameter p) => Enum.Parse<EnumEventType>(p.Value);

      #endregion

      #region GLI

      public static implicit operator EnumElementType(Parameter p) => Enum.Parse<EnumElementType>(p.Value);
      public static implicit operator EnumMaterialType(Parameter p) => Enum.Parse<EnumMaterialType>(p.Value);
      public static implicit operator EnumChromaKeyEnabled(Parameter p) => Enum.Parse<EnumChromaKeyEnabled>(p.Value);
      public static implicit operator EnumChromaKeyFilter(Parameter p) => Enum.Parse<EnumChromaKeyFilter>(p.Value);
      public static implicit operator EnumPriority(Parameter p) => Enum.Parse<EnumPriority>(p.Value);
      public static implicit operator EnumQuality(Parameter p) => Enum.Parse<EnumQuality>(p.Value);
      public static implicit operator CPAScriptSerializer.Modules.GMT.Enums.EnumOnOffToggle(Parameter p) => Enum.Parse<CPAScriptSerializer.Modules.GMT.Enums.EnumOnOffToggle>(p.Value);

      #endregion

      #region GMT

      public static implicit operator CPAScriptSerializer.Modules.GLI.Enums.EnumOnOffToggle(Parameter p) => Enum.Parse<CPAScriptSerializer.Modules.GLI.Enums.EnumOnOffToggle>(p.Value);

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