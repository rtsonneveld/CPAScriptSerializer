using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {

   public class LoadEvent : Command
   {
      public string EventName;

      public override void Fill(Parameter[] parameters)
      {
         EventName = parameters[0];
      }
   }
}
