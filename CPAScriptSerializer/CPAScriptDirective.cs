using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAScriptSerializer
{
   public class CPAScriptDirective : CPAScriptItem
   {
      public string Directive;

      public void Read(CPAScript script, StreamReader reader, string lastLine)
      {
         Directive = lastLine;
      }

      public void Write(ref int indent, StreamWriter writer)
      {
         // Ignore indent
         writer.WriteLine(Directive);
      }
   }
}