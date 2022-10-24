using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;

namespace CPAScriptSerializer.Modules.Editor.OAC.Commands.MiniStructureCommands {

   public class Sect_Info
   {

      public class Current_Sector : MiniStructureCommandBase
      {
         [CommandParameter(1, customDefaultValue: "No Sector!")] public string CurrentSectorName;
      };

      public class Previous_Sector : MiniStructureCommandBase {
         [CommandParameter(1, customDefaultValue: "No Sector!")] public string PreviousSectorName;
      };

   }
}
