using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OZO.Sections;
using CPAScriptSerializer.Modules.Editor.TAC.Sections;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.CollSet
{
   public class ZdxActivationTable : Command
   {
      [CommandParameter(0)] public CPAScriptReference<CreateNewArrayOfZoneSet> ZdxArray;
   }

   public class ZdmActivationTable : ZdxActivationTable { };
   public class ZddActivationTable : ZdxActivationTable { };
   public class ZdeActivationTable : ZdxActivationTable { };
   public class ZdrActivationTable : ZdxActivationTable { };

}
