using System;
using System.Linq;
using System.Reflection;
using CPAScriptSerializer.Modules.AI.Commands.RULRFX.Nodes;
using CPAScriptSerializer.Modules.AI.Enums;
using CPAScriptSerializer.Modules.Editor.OAC.Enums;
using CPAScriptSerializer.Modules.GAM.Enums;
using CPAScriptSerializer.Modules.GLI.Enums;
using CPAScriptSerializer.Modules.IPT.Enums;
using CPAScriptSerializer.Modules.SND.Enums;
using EnumLightType = CPAScriptSerializer.Modules.GAM.Enums.EnumLightType;

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

                  if (fieldSettings.CustomDefaultValue != null && parameters[fieldSettings.Index].Value == fieldSettings.CustomDefaultValue) {

                     // First check for a custom default value
                     fieldValue = field.FieldType.IsValueType ? Activator.CreateInstance(field.FieldType) : null;

                  }  else if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(CPAScriptReference<>)) {

                     // Then handle cpa script reference types
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

      #region AI

      public static implicit operator EnumCondition(Parameter p) => ParseEnumParam<EnumCondition>(p.Value);
      public static implicit operator EnumDsgVarSaveType(Parameter p) => ParseEnumParam<EnumDsgVarSaveType>(p.Value);
      public static implicit operator EnumDsgVarInitType(Parameter p) => ParseEnumParam<EnumDsgVarInitType>(p.Value);
      public static implicit operator EnumField(Parameter p) => ParseEnumParam<EnumField>(p.Value);
      public static implicit operator EnumFunction(Parameter p) => ParseEnumParam<EnumFunction>(p.Value);
      public static implicit operator EnumKeyWord(Parameter p) => ParseEnumParam<EnumKeyWord>(p.Value);
      public static implicit operator EnumMetaAction(Parameter p) => ParseEnumParam<EnumMetaAction>(p.Value);
      public static implicit operator EnumOperator(Parameter p) => EnumOperatorUtils.Parse(p.Value);
      public static implicit operator EnumProcedure(Parameter p) => ParseEnumParam<EnumProcedure>(p.Value);

      #endregion

      #region IPT

      public static implicit operator EnumJoyPadAxe(Parameter p) => ParseEnumParam<EnumJoyPadAxe>(p.Value);
      public static implicit operator EnumJoyPadButton(Parameter p) => ParseEnumParam<EnumJoyPadButton>(p.Value);
      public static implicit operator EnumRefType(Parameter p) => ParseEnumParam<EnumRefType>(p.Value.Replace("ForAllVersions", "ForAllVersion")); // Stupid typo D:

      #endregion

      #region SND

      public static implicit operator EnumStorageType(Parameter p) => ParseEnumParam<EnumStorageType>(p.Value);
      public static implicit operator EnumResourceType(Parameter p) => ParseEnumParam<EnumResourceType>(p.Value);
      public static implicit operator EnumZipFormat(Parameter p) => ParseEnumParam<EnumZipFormat>(p.Value);
      public static implicit operator EnumEventType(Parameter p) => ParseEnumParam<EnumEventType>(p.Value);
      public static implicit operator EnumTransitionType(Parameter p) => ParseEnumParam<EnumTransitionType>(p.Value);

      #endregion

      #region GAM
      public static implicit operator EnumTransitionStatusFlag(Parameter p) => ParseEnumParam<EnumTransitionStatusFlag>(p.Value);
      public static implicit operator EnumInitFlags(Parameter p) => ParseEnumParam<EnumInitFlags>(p.Value);
      public static implicit operator EnumDynamSize(Parameter p) => ParseEnumParam<EnumDynamSize>(p.Value);
      public static implicit operator EnumGenericEventType(Parameter p) => ParseEnumParam<EnumGenericEventType>(p.Value);
      public static implicit operator EnumObjectType(Parameter p) => ParseEnumParam<EnumObjectType>(p.Value);
      public static implicit operator EnumLightType(Parameter p) => ParseEnumParam<EnumLightType>(p.Value);
      public static implicit operator EnumLoadMode(Parameter p) => ParseEnumParam<EnumLoadMode>(p.Value);
      public static implicit operator Modules.GAM.Enums.EnumOnOffToggle(Parameter p) => ParseEnumParam<Modules.GAM.Enums.EnumOnOffToggle>(p.Value);
      #endregion

      #region GLI

      public static implicit operator EnumElementType(Parameter p) => ParseEnumParam<EnumElementType>(p.Value);
      public static implicit operator EnumMaterialType(Parameter p) => ParseEnumParam<EnumMaterialType>(p.Value);
      public static implicit operator EnumObjectLighted(Parameter p) => ParseEnumParam<EnumObjectLighted>(p.Value);
      public static implicit operator EnumChromaKeyEnabled(Parameter p) => ParseEnumParam<EnumChromaKeyEnabled>(p.Value);
      public static implicit operator EnumChromaKeyFilter(Parameter p) => ParseEnumParam<EnumChromaKeyFilter>(p.Value);
      public static implicit operator EnumMipMapping(Parameter p) => ParseEnumParam<EnumMipMapping>(p.Value);
      public static implicit operator EnumPriority(Parameter p) => ParseEnumParam<EnumPriority>(p.Value);
      public static implicit operator EnumQuality(Parameter p) => ParseEnumParam<EnumQuality>(p.Value);
      public static implicit operator EnumSpriteMode(Parameter p) => ParseEnumParam<EnumSpriteMode>(p.Value);
      public static implicit operator Modules.GMT.Enums.EnumOnOffToggle(Parameter p) => ParseEnumParam<Modules.GMT.Enums.EnumOnOffToggle>(p.Value);

      #endregion

      #region GMT

      public static implicit operator Modules.GLI.Enums.EnumOnOffToggle(Parameter p) => ParseEnumParam<Modules.GLI.Enums.EnumOnOffToggle>(p.Value);

      #endregion

      #region TGM

      public static implicit operator Modules.Editor.TGM.Enums.EnumZoneType(Parameter p) => ParseEnumParam<Modules.Editor.TGM.Enums.EnumZoneType>(p.Value);

      #endregion


      #region TIA

      public static implicit operator Modules.Editor.TIA.Enums.EnumLanguage(Parameter p) => ParseEnumParam<Modules.Editor.TIA.Enums.EnumLanguage>(p.Value);

      #endregion

      #region OAC

      // Spaces = Underscore
      public static implicit operator Modules.Editor.OAC.Enums.EnumAllocation(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumAllocation>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumCollisionFlags(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumCollisionFlags>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumGroup(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumGroup>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumLightType(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumLightType>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumLinkedState(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumLinkedState>(p.Value, true);
      public static implicit operator Modules.Editor.OAC.Enums.EnumModelType(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumModelType>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumObjectinitInit(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumObjectinitInit>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumPlatformType(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumPlatformType>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumShadowQuality(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumShadowQuality>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumShareMode(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumShareMode>(p.Value);
      public static implicit operator Modules.Editor.OAC.Enums.EnumNameListType(Parameter p) => ParseEnumParam<Modules.Editor.OAC.Enums.EnumNameListType>(p.Value);

      #endregion

      #endregion

      public static string ExportValue(object? value, CommandParameterAttribute fieldSettings)
      {
         if (value == default && fieldSettings.CustomDefaultValue != null) {
            return fieldSettings.CustomDefaultValue;
         }

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

         if (value.GetType().GetCustomAttributes<SerializeEnumAsValueAttribute>().Any()) {
            return ((int)value).ToString();
         }

         if (value.GetType().GetCustomAttributes<ReplaceUnderscoresEnumAttribute>().FirstOrDefault() is { } attribute) {
            return valueString.Replace("_", attribute.ReplacementString);
         }

         return value switch
         {
            bool => valueString.ToUpper(),
            float or double => $"\"{value:F6}\"",
            string => '"' + valueString + '"',
            _ => valueString
         };

      }

      public static T ParseEnumParam<T>(Parameter p, bool ignoreCase = true) where T: struct,Enum
      {
         string str = p.Value;

         if (typeof(T).GetCustomAttributes<SerializeEnumAsValueAttribute>().Any()) {
            return (T)Enum.ToObject(typeof(T), int.Parse(p.Value));
         }

         if (typeof(T).GetCustomAttributes<ReplaceUnderscoresEnumAttribute>().FirstOrDefault() is { } attribute) {
            if (string.IsNullOrEmpty(attribute.ReplacementString)) {
               str = "_" + str;
            } else {
               str = str.Replace(attribute.ReplacementString, "_");
            }
         }

         return Enum.Parse<T>(str, ignoreCase);
      }
   }
}