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
      /// <summary>
      /// Implement this function to read a script item
      /// </summary>
      /// <param name="script">The script context</param>
      /// <param name="section">The current section context (can be null!)</param>
      /// <param name="reader">The reader</param>
      /// <param name="lastLine">The last read line</param>
      public void Read(CPAScript script, CPAScriptSection section, StreamReader reader, string lastLine);

      /// <summary>
      /// Implement this function to write a script item
      /// </summary>
      /// <param name="indent">The current indent level, increase and decrease where necessary - <b>the implementing function is responsible for writing the indentation!</b></param>
      /// <param name="writer">The writer</param>
      public void Write(ref int indent, StreamWriter writer);
   }
}