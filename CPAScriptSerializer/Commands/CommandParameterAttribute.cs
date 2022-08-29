using System;
using System.Collections.Generic;
using System.Text;

namespace CPAScriptSerializer.Commands
{
   public class CommandParameterAttribute : Attribute
   {
      public int Index { get; set; }

      public CommandParameterAttribute(int index)
      {
         Index = index;
      }
   }
}