using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CPAScriptSerializer.Commands
{
   public abstract class Command : CPAScriptItem
   {
      // The name of the command, which is usually the same as the type
      public string Name;
      public string Format;

      /// <summary>
      /// Parses a command from a line
      /// </summary>
      /// <param name="line">The line to parse, e.g. SetNextFreeGroupId[%lu](101)</param>
      /// <param name="commandName">The command name, e.g. SetNextFreeGroupId</param>
      /// <param name="format">The format, e.g. %lu</param>
      /// <param name="parameters">Array of parameters, e.g. 101</param>
      public static void Parse(string line, out string commandName, out string format, out Parameter[] parameters)
      {
         // Command
         var paramBegin = line.IndexOf(CPAScript.MarkParamBegin);
         var paramEnd = line.IndexOf(CPAScript.MarkParamEnd);

         var formatBegin = line.IndexOf(CPAScript.MarkFormatBegin);
         var formatEnd = line.IndexOf(CPAScript.MarkFormatEnd);

         /*
          * Extract the command name, three possible cases:
          * SetNextFreeGroupId[%lu](101) - format parameter
          * SetNextFreeGroupId(101) - only normal parameters
          * SetNextFreeGroupId - no parameters
          */
         commandName =
            (formatBegin >= 0 ? line[0..formatBegin] : (paramBegin >= 0 ? line[0..paramBegin] : line)).Trim();

         // Parse parameters
         parameters = Array.Empty<Parameter>();

         if (paramBegin > 0 && paramEnd > paramBegin + 1) {
            parameters = Array.ConvertAll(line[(paramBegin + 1)..(paramEnd)].Split(CPAScript.MarkParamSeparator),
               item => (Parameter)item);
         }

         // Parse format
         format = string.Empty;

         if (formatBegin > 0 && formatEnd > formatBegin + 1) {
            format = line[(formatBegin + 1)..(formatEnd)];
         }
      }

      public void Read(CPAScript script, StreamReader reader, string line)
      {
         Command.Parse(line, out _, out var format, out var parameters);

         Format = format;
         Fill(parameters);
      }

      /// <summary>
      /// Fills the fields of this object marked with the "CommandParameter" attribute using the given Parameter array
      /// </summary>
      /// <param name="parameters">The parameter array to fill in</param>
      private void Fill(Parameter[] parameters)
      {
         var instanceFields = GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);

         foreach (var field in instanceFields) {
            var fieldSettings = field.GetCustomAttribute<CommandParameterAttribute>();
            if (fieldSettings != null) {
               if (fieldSettings.Index < parameters.Length) {
                  // We need to find the implicit operator for the Parameter object
                  var converter = typeof(Parameter).GetMethods().FirstOrDefault(m =>
                     m.Name == "op_Implicit" && m.ReturnParameter?.ParameterType == field.FieldType);

                  if (converter != null) {
                     field.SetValue(this, converter.Invoke(null, new object[] { parameters[fieldSettings.Index] }));
                  } else {
                     throw new Exception($"No implicit conversion found for field type {field.FieldType}!");
                  }
               }
            }
         }
      }

      /// <summary>
      /// Write the specified command to the stream
      /// </summary>
      /// <param name="indent"></param>
      /// <param name="writer">The stream writer</param>
      public void Write(ref int indent, StreamWriter writer)
      {
         List<string> parameterList = new List<string>();

         var instanceFields = GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);

         foreach (var field in instanceFields) {
            var fieldSettings = field.GetCustomAttribute<CommandParameterAttribute>();
            if (fieldSettings != null) {
               parameterList.Add(field.GetValue(this)?.ToString() ?? string.Empty);
            }
         }

         // TypeName[parameters](parameter1,parameter2,...)
         // Examples:
         // LoadEventGroup(EXPLOS,27)
         // SetNextFreeGroupId[%lu](101)

         string format = string.IsNullOrWhiteSpace(Format)
            ? string.Empty
            : CPAScript.MarkFormatBegin + Format + CPAScript.MarkFormatEnd;
         string parameters = string.Join(CPAScript.MarkParamSeparator, parameterList);

         writer.WriteLine($"{CPAScript.Indent(indent)}" +
                          $"{Name}" +
                          $"{format}" +
                          $"{CPAScript.MarkParamBegin}" +
                          $"{parameters}" +
                          $"{CPAScript.MarkParamEnd}");
      }
   }
}