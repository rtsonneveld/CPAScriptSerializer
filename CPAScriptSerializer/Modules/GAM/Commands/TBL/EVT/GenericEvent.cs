using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.GAM.Enums;

namespace CPAScriptSerializer.Modules.GAM.Commands.TBL.EVT {
   public class GenericEvent : Command
   {
      [CommandParameter(0)] public EnumGenericEventType GenericEventType;
   }
}
