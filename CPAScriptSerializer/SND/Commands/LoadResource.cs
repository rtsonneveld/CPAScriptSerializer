using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class LoadResource : Command
   {
      [ParameterSettings(0)]
      public string ResourcePath;
   }
}
