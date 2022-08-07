using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CPAScriptSerializer.Commands {

   public abstract class Command
   {
      public string Format;
      
      /// <summary>
      /// Fills the fields of this object marked with the "CommandParameter" attribute using the given Parameter array
      /// </summary>
      /// <param name="parameters">The parameter array to fill in</param>
      public void Fill(Parameter[] parameters)
      {
         var instanceFields = GetType().GetFields(BindingFlags.Public|BindingFlags.Instance);

         foreach (var field in instanceFields) {
            var fieldSettings = field.GetCustomAttribute<CommandParameterAttribute>();
            if (fieldSettings != null) {

               if (fieldSettings.Index < parameters.Length) {

                  // We need to find the implicit operator for the Parameter object
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
