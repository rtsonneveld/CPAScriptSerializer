using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAScriptSerializer
{
   public interface CPAScriptItem
   {
      public void Read(CPAScript script, StreamReader reader, string lastLine);
      public void Write(ref int indent, StreamWriter writer);
   }
}