using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CPAScriptSerializer.Commands {

   public abstract class Command
   {
      public string Format;
      
      /// <summary>
      /// Implement this method where you parse each parameter and fill each field of your command object
      /// </summary>
      /// <param name="parameters">The list of parameters</param>
      public void Fill(Parameter[] parameters)
      {
         var instanceFields = GetType().GetFields(BindingFlags.Public|BindingFlags.Instance);

         foreach (var field in instanceFields) {
            var fieldSettings = field.GetCustomAttribute<ParameterSettings>();
            if (fieldSettings != null) {

               if (fieldSettings.Index < parameters.Length) {

                  var paramType = typeof(Parameter);

                  // We need to find the implicit operator for the Parameter object
                  // "op_Implicit", new[] { typeof(string) }, 
                  var converter = typeof(Parameter).GetMethods().FirstOrDefault(m => m.Name == "op_Implicit" && m.ReturnParameter?.ParameterType == field.FieldType);

                  if (converter != null) {
                     field.SetValue(this, converter.Invoke(null, new object[] { parameters[fieldSettings.Index] }));
                  } else {
                     throw new Exception($"No implicit conversion found for field type {field.FieldType}!");
                  }
               }
            }
         }
      }
   }
}
