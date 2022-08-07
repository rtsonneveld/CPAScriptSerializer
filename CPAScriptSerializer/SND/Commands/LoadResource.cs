using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class LoadResource : Command
   {
      public string ResourcePath;

      public override void Fill(Parameter[] parameters)
      {
         ResourcePath = parameters[0];
      }
   }
}
