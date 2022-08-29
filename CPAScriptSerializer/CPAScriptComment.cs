using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAScriptSerializer
{
   public class CPAScriptComment : CPAScriptItem
   {
      public string Comment;

      public void Read(CPAScript script, CPAScriptSection section, StreamReader reader, string lastLine)
      {
         Comment = lastLine;
      }

      public void Write(ref int indent, StreamWriter writer)
      {
         // Ignore indent
         writer.WriteLine(Comment);
      }
   }
}