using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer
{
   public abstract class CPAScriptSection : CPAScriptItem
   {
      public readonly string SectionId;

      /// <summary>
      /// Dictionary values must be a Type that inherits CPAScriptCommand
      /// </summary>
      public abstract Dictionary<string, Type> CommandTypes { get; }

      /// <summary>
      /// In case the command type can't be found, it's possible to provide a default fallback
      /// </summary>
      public abstract Type CommandTypeFallback { get; }

      public List<CPAScriptItem> Items;

      public CPAScriptSection(string sectionId)
      {
         SectionId = sectionId;
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
         Type typeToGenerate = CommandTypes.ContainsKey(commandType) ? CommandTypes[commandType] : CommandTypeFallback;

         if (typeToGenerate == null) {
            throw new ArgumentException($"Unknown command type {commandType} and no fallback provided");
         }

         var constructor = typeToGenerate.GetConstructor(Type.EmptyTypes);
         if (constructor != null) {
            var cmd = Activator.CreateInstance(typeToGenerate) as Command;
            if (cmd == null) {
               throw new Exception($"Failed to generate command {commandType}");
            }

            cmd.Name = commandType;
            return cmd;
         }

         throw new Exception($"No constructor found for command {commandType}");
      }

      public void Read(CPAScript script, StreamReader reader, string lastLine)
      {
         var line = reader.ReadLine();

         while (line != null && line.Trim()[0] != CPAScript.MarkSectionEnd) {
            line = line.Trim();

            if (line.StartsWith(CPAScript.MarkSectionBegin)) {
               // Subsection

               CPAScriptSection.Parse(line, out string sectionType, out string sectionId);
               var section = script.GenerateSection(sectionType, sectionId);
               section.Read(script, reader, line);

               Items.Add(section);
            } else {
               Command.Parse(line, out string commandName, out _, out _);
               var command = GenerateCommand(commandName);
               command.Read(script, reader, line);

               Items.Add(command);
            }

            line = reader.ReadLine();
         }
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

      public void Write(ref int indent, StreamWriter writer)
      {
         writer.WriteLine($"{CPAScript.Indent(indent)}{CPAScript.MarkSectionBegin}{GetType().Name}:{SectionId}");
         //WriteContent(writer);

         indent++;

         foreach (var command in Items) {
            command.Write(ref indent, writer);
         }

         indent--;

         writer.WriteLine(CPAScript.MarkSectionEnd);
      }
   }
}