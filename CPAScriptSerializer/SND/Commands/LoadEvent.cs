using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class LoadEvent : Command
   {
      [CommandParameter(0)]
      public string EventName;
   }
}
