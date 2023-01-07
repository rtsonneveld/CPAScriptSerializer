using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands
{
   public class CommandParameterAttribute : Attribute
   {
      public int Index { get; set; }
      /// <summary>
      /// Set this string to a non-null value to make the parser  interpret the specified value as "default" - it will also be exported in that way.
      /// </summary>
      public string CustomDefaultValue = null;
      public readonly object[] IgnoreValues = null;

      public CommandParameterAttribute(int index, string customDefaultValue = null, object[] ignoreValues = null)
      {
         Index = index;
         CustomDefaultValue = customDefaultValue;
         IgnoreValues = ignoreValues ?? Array.Empty<object>();
      }
   }
}