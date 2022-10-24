using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.Editor.OZO.Sections;

namespace CPAScriptSerializer.Modules.GAM.Commands.CAR.CollSet
{
   public class ZdxTable : Command
   {
      [CommandParameter(0)] public CPAScriptReference<CreateNewArrayOfZdx> ZdxArray;
   }

   public class ZdmTable : ZdxTable { };
   public class ZddTable : ZdxTable { };
   public class ZdeTable : ZdxTable { };
   public class ZdrTable : ZdxTable { };

}
