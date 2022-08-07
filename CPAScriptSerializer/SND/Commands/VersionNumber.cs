using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {
   public class VersionNumber : Command
   {
      public int Version;

      public override void Fill(Parameter[] parameters)
      {
         Version = parameters[0];
      }
   }
}
