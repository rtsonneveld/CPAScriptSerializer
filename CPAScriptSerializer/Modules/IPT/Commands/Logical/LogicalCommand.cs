using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.IPT.Commands.Logical {

   /// <summary>
   /// A special, non-standard "command" (of course), which is used to implement conditions for .IPT files, i.e. And, Not, Or
   /// </summary>
   public abstract class LogicalCommand : Command
   {
      public List<CPAScriptItem> SubItems;
      public abstract int SubItemCount { get; }

      public override void Read(CPAScript script, CPAScriptSection section, StreamReader reader, string line)
      {
         SubItems = new List<CPAScriptItem>();
         for (int i = 0; i < SubItemCount; i++) {
            SubItems.Add(section.ParseLine(script, section, reader, reader.ReadLine()));
         }
      }

      public override void Write(ref int indent, StreamWriter writer) {
         writer.WriteLine(CPAScript.Indent(indent)+GetType().Name);
         indent++;
         foreach (var item in SubItems) {
            item.Write(ref indent, writer);
         }
         indent--;
      }
   }
}
