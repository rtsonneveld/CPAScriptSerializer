using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer
{
   public abstract class CPAScriptSection : CPAScriptItem
   {
      public string SectionId;
      public string SectionType;

      /// <summary>
      /// Override this to change how the ID of this section is exported, by default this returns SectionId
      /// </summary>
      public virtual string SectionExportId => SectionId;
      /// <summary>
      /// Override this to change how the type name of this section is exported.
      /// </summary>
      public virtual string SectionExportType => SectionType;

      /// <summary>
      /// Dictionary values must be a Type that inherits CPAScriptCommand
      /// </summary>
      public abstract Dictionary<string, Type> CommandTypes { get; }

      /// <summary>
      /// In case the command type can't be found, it's possible to provide a default fallback
      /// </summary>
      public virtual Type CommandTypeFallback(string name) => null;

      public List<CPAScriptItem> Items;
      public string Format;

      public CPAScriptSection(string sectionId, string sectionType = null)
      {
         Command.Parse(sectionId, out string commandName, out Format, out var parameters);
         SectionId = commandName;
         SectionType = sectionType ?? GetType().Name;
         Fill(parameters);
         Items = new List<CPAScriptItem>();
      }

      public static void Parse(string line, out string sectionType, out string sectionId)
      {
         // A section has a type and an ID, e.g. {InputAction:ReinitTheMap
         int sectionIdChar = line.IndexOf(CPAScript.MarkSectionId);

         sectionType = (sectionIdChar > 0) ? line[1..sectionIdChar] : line[1..];
         sectionId = (sectionIdChar > 0) ? line[(sectionIdChar + 1)..] : string.Empty;
      }

      public Command GenerateCommand(string commandType)
      {
         Type typeToGenerate = CommandTypes.ContainsKey(commandType) ? CommandTypes[commandType] : CommandTypeFallback(commandType);

         if (typeToGenerate == null) {
            throw new ArgumentException($"Unknown command type {commandType} and no fallback provided");
         }

         var constructor = typeToGenerate.GetConstructor(Type.EmptyTypes);
         if (constructor != null) {
            var cmd = Activator.CreateInstance(typeToGenerate) as Command;
            if (cmd == null) {
               throw new Exception($"Failed to generate command {commandType} - check if the class extends Command");
            }

            cmd.Name = commandType;
            return cmd;
         }

         throw new Exception($"No constructor found for command {commandType}");
      }

      public void Read(CPAScript script, CPAScriptSection section, StreamReader reader, string lastLine)
      {
         var line = reader.ReadLine();

         while (line != null && (string.IsNullOrWhiteSpace(line) || line.Trim()[0] != CPAScript.MarkSectionEnd)) {

            if (!string.IsNullOrWhiteSpace(line)) {

               line = line.Trim();

               var item = ParseLine(script, section, reader, line);
               Items.Add(item);
            }

            line = reader.ReadLine();
         }

         this.ValidateParameters();
      }
      
      // Parses a single line in a section
      public CPAScriptItem ParseLine(CPAScript script, CPAScriptSection section, StreamReader reader, string line)
      {
         // Make sure the line is trimmed
         line = line.Trim();

         CPAScriptItem item = null;

         // Ignore comments
         if (line.StartsWith(CPAScript.MarkComment)) {
            var comment = new CPAScriptComment();
            comment.Read(script, section, reader, line);
            item = comment;
         } else if (line.StartsWith(CPAScript.MarkSectionBegin)) {
            // Subsection

            CPAScriptSection.Parse(line, out string sectionType, out string sectionId);
            var newSection = script.GenerateSection(sectionType, sectionId);
            newSection.Read(script, this, reader, line);

            item = newSection;
         } else {
            Command.Parse(line, out string commandName, out _, out _);
            var command = GenerateCommand(commandName);

            command.Read(script, this, reader, line);
            item = command;
         }

         if (item == null) {
            throw new Exception($"Could not parse line {line}");
         }

         return item;
      }

      private static List<string> ReadLines(StreamReader reader)
      {
         var line = reader.ReadLine();
         var lines = new List<string>();
         while (line != null && line[0] != CPAScript.MarkSectionEnd) {
            lines.Add(line);

            line = reader.ReadLine();
         }

         return lines;
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

      public void Write(ref int indent, StreamWriter writer)
      {
         ValidateParameters();
         var parameterList = Parameter.BuildParameterList(this);

         string format = string.IsNullOrWhiteSpace(Format)
            ? string.Empty
            : CPAScript.MarkFormatBegin + Format + CPAScript.MarkFormatEnd;
         string parameters = string.Join(CPAScript.MarkParamSeparator, parameterList.Values);
         if (!string.IsNullOrWhiteSpace(parameters)) {
            parameters = $"{CPAScript.MarkParamBegin}{parameters}{CPAScript.MarkParamEnd}";
         }

         writer.WriteLine($"{CPAScript.Indent(indent)}{CPAScript.MarkSectionBegin}{SectionExportType}:{format}{SectionExportId}{parameters}");
         //WriteContent(writer);

         indent++;

         foreach (var command in Items) {
            command.Write(ref indent, writer);
         }

         indent--;

         writer.WriteLine(CPAScript.Indent(indent)+CPAScript.MarkSectionEnd);
      }

      /// <summary>
      /// Override this method to add validation for any parameters
      /// </summary>
      public virtual void ValidateParameters() { }
   }
}