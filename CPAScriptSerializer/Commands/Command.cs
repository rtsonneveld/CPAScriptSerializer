using System;
using System.Collections.Generic;
using System.Diagnostics;
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
      /// Override this method to use a different export name
      /// </summary>
      public virtual string ExportName => string.IsNullOrEmpty(Name) ? GetType().Name : Name;

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
         var paramEnd = line.LastIndexOf(CPAScript.MarkParamEnd);

         var formatBegin = line.IndexOf(CPAScript.MarkFormatBegin);
         var formatEnd = line.IndexOf(CPAScript.MarkFormatEnd);

         /*
          * Extract the command name, three possible cases:
          * SetNextFreeGroupId[%lu](101) - format parameter
          * SetNextFreeGroupId(101) - only normal parameters
          * SetNextFreeGroupId - no parameters
          */
         commandName =
            ((formatBegin >= 0 && (formatBegin<paramBegin||paramBegin==-1)) ? line[0..formatBegin] : (paramBegin >= 0 ? line[0..paramBegin] : line)).Trim();

         // Parse parameters
         parameters = Array.Empty<Parameter>();

         if (paramBegin >= 0 && paramEnd > paramBegin + 1) {
            string paramPart = line[(paramBegin + 1)..(paramEnd)];
            string[] splitLine = paramPart.SplitSeparatedValues(CPAScript.MarkParamSeparator, CPAScript.MarkString);

            parameters = Array.ConvertAll(splitLine,
            item => (Parameter)item);
         }

         // Parse format
         format = string.Empty;

         if (formatBegin > 0 && formatEnd > formatBegin + 1 && formatBegin<paramBegin) {
            format = line[(formatBegin + 1)..(formatEnd)];
         }
      }

      public virtual void Read(CPAScript script, CPAScriptSection section, StreamReader reader, string line)
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
         Parameter.FillParameters(this, parameters);

         ValidateParameters();
      }

      /// <summary>
      /// Write the specified command to the stream
      /// </summary>
      /// <param name="indent"></param>
      /// <param name="writer">The stream writer</param>
      public virtual void Write(ref int indent, StreamWriter writer)
      {
         ValidateParameters();
         var parameterList = Parameter.BuildParameterList(this);

         // TypeName[parameters](parameter1,parameter2,...)
         // Examples:
         // LoadEventGroup(EXPLOS,27)
         // SetNextFreeGroupId[%lu](101)

         string format = string.IsNullOrWhiteSpace(Format)
            ? string.Empty
            : CPAScript.MarkFormatBegin + Format + CPAScript.MarkFormatEnd;
         string parameters = string.Join(CPAScript.MarkParamSeparator, parameterList.Values);

         writer.WriteLine($"{CPAScript.Indent(indent)}" +
                          $"{(string.IsNullOrWhiteSpace(Name) ? ExportName : Name)}" +
                          $"{format}" +
                          $"{CPAScript.MarkParamBegin}" +
                          $"{parameters}" +
                          $"{CPAScript.MarkParamEnd}");
      }

      /// <summary>
      /// Override this method to add validation for any parameters
      /// </summary>
      public virtual void ValidateParameters() { }
   }
}