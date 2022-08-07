using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer {
	public abstract class CPAScriptSection : CPAScriptItem
	{
		public readonly string SectionId;

      /// <summary>
      /// Dictionary values must be a Type that inherits CPAScriptCommand
      /// </summary>
		public abstract Dictionary<string, Type> CommandTypes { get; }

      public List<Command> Commands;

		public CPAScriptSection(string sectionId)
		{
			SectionId = sectionId;
         Commands = new List<Command>();
      }

      public Command GenerateCommand(string commandType)
      {
         if (!CommandTypes.ContainsKey(commandType)) {
            throw new ArgumentException($"Unknown command type {commandType}");
         }

         var constructor = CommandTypes[commandType].GetConstructor(Type.EmptyTypes);
         if (constructor != null) {
            return Activator.CreateInstance(CommandTypes[commandType]) as Command;
         }

         return null;
      }

		public void Parse(string[] lines)
		{
         foreach (var line in lines) {

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
            string commandName =
               (formatBegin >= 0 ? line[0 .. formatBegin] : (paramBegin >= 0 ? line[0 .. paramBegin] : line)).Trim();

            Parameter[] parameters = Array.Empty<Parameter>();

            string format = string.Empty;

            if (paramBegin > 0 && paramEnd > paramBegin+1) {
               parameters = Array.ConvertAll(line[(paramBegin + 1) .. (paramEnd)].Split(CPAScript.MarkParamSeparator), item => (Parameter)item);
            }

            if (formatBegin > 0 && formatEnd > formatBegin + 1) {
               format = line[(formatBegin + 1) .. (formatEnd)];
            }

            var command = GenerateCommand(commandName);
            command.Format = format;
            command.Fill(parameters);

            Commands.Add(command);
         }
		}

		public override void Write(StreamWriter writer)
		{
			writer.WriteLine($"{CPAScript.MarkSectionBegin}{GetType().Name}:{SectionId}");
			WriteContent(writer);
			writer.WriteLine(CPAScript.MarkSectionEnd);
		}

		public abstract void WriteContent(StreamWriter writer);
	}
}
