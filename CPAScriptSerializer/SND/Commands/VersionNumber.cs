using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {
   public class VersionNumber : Command
   {
      [CommandParameter(0)]
      public int Version;
   }
}
