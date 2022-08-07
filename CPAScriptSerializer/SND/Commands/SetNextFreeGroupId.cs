using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.SND.Commands {
   public class SetNextFreeGroupId : Command
   {

      public int NextFreeGroupId;

      public override void Fill(Parameter[] parameters)
      {
         NextFreeGroupId = parameters[0];
      }
   }
}
