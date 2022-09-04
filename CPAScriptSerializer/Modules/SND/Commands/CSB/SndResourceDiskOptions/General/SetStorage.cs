using System;
using System.Collections.Generic;
using System.Text;
using CPAScriptSerializer.Commands;
using CPAScriptSerializer.Modules.SND.Enums;

namespace CPAScriptSerializer.Modules.SND.Commands.CSB.SndResourceDiskOptions.General {
   public class SetStorage : Command {
      [CommandParameter(0)] public EnumStorageType Storage;
   }
}
