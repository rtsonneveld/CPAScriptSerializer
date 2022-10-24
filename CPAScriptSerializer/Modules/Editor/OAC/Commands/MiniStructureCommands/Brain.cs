using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {

   public class Brain
   {

      public class FastC_Run : MiniStructureCommandBase
      {
         [CommandParameter(1)] public bool Run;
      };

      public class FastC_Index : MiniStructureCommandBase
      {
         [CommandParameter(1)] public int Index;
      };

   }
}
